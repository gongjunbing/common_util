using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;

namespace CommonUtil.Excel
{
    /// <summary>
    /// Excel工具类
    /// </summary>
    public class ExcelUtil
    {
        /// <summary>
        /// 导出excel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entitys">数据源</param>
        /// <param name="title">导出的列名</param>
        /// <param name="listcolum">导出的列</param>
        /// <returns></returns>
        public static byte[] Output<T>(List<T> entitys, string[] title, List<string> listcolum)
        {
            IWorkbook workbook = new XSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("sheet");
            ISheet sheet1 = workbook.CreateSheet("sheet1");
            ISheet sheet2 = workbook.CreateSheet("sheet2");
            IRow Title = null;
            IRow rows = null;
            Type entityType = entitys[0].GetType();
            PropertyInfo[] entityProperties = entityType.GetProperties();

            try
            {
                for (int i = 0; i <= entitys.Count; i++)
                {
                    if (i == 0)
                    {
                        Title = sheet.CreateRow(0);
                        for (int k = 1; k < title.Length + 1; k++)
                        {
                            Title.CreateCell(0).SetCellValue("序号");
                            Title.CreateCell(k).SetCellValue(title[k - 1]);
                        }

                        continue;
                    }
                    else
                    {
                        rows = sheet.CreateRow(i);
                        object entity = entitys[i - 1];
                        for (int c = 0; c <= listcolum.Count - 1; c++)
                        {
                            for (int j = 1; j <= entityProperties.Length; j++)
                            {
                                if (entityProperties[j - 1].Name == listcolum[c])
                                {
                                    var dem = entityProperties[j - 1].GetValue(entity);
                                    rows.CreateCell(0).SetCellValue(i);

                                    rows.CreateCell(c + 1).SetCellValue(dem.ToString());
                                }
                            }

                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            byte[] buffer = new byte[1024 * 2];
            using (MemoryStream ms = new MemoryStream())
            {
                workbook.Write(ms);
                buffer = ms.GetBuffer();
            }
            return buffer;
        }

        /// <summary>
        /// 导入Excel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ms">数据流</param>
        /// <returns></returns>
        public static List<T> InputExcel<T>(Stream ms) where T : new()
        {
            List<T> list = new List<T> { };
            ms.Seek(0, SeekOrigin.Begin);
            IWorkbook workbook = null;
            try
            {
                //xlsx
                workbook = new XSSFWorkbook(ms);
            }
            catch (Exception)
            {
                //xls
                workbook = new HSSFWorkbook(ms);
            }



            ISheet sheet = workbook.GetSheetAt(0);
            IRow cellNum = sheet.GetRow(0);
            var propertys = typeof(T).GetProperties();
            string value = null;
            int num = cellNum.LastCellNum;

            for (int i = 0; i <= sheet.LastRowNum; i++)
            {
                IRow row = sheet.GetRow(i);
                if (row == null)
                {
                    continue;
                }
                var obj = new T();
                for (int j = 0; j < num; j++)
                {
                    //当输出类型属性个数小于文件列数时，跳出
                    if (propertys.Length - 1 < j)
                    {
                        break;
                    }
                    if (row.GetCell(j) == null)
                    {
                        continue;
                    }
                    value = row.GetCell(j).ToString();
                    string str = (propertys[j].PropertyType).FullName;
                    if (str == "System.String")
                    {
                        propertys[j].SetValue(obj, value, null);
                    }
                    else if (str == "System.DateTime")
                    {
                        DateTime pdt = Convert.ToDateTime(value, CultureInfo.InvariantCulture);
                        propertys[j].SetValue(obj, pdt, null);
                    }
                    else if (str == "System.Boolean")
                    {
                        bool pb = Convert.ToBoolean(value);
                        propertys[j].SetValue(obj, pb, null);
                    }
                    else if (str == "System.Int16")
                    {
                        short pi16 = Convert.ToInt16(value);
                        propertys[j].SetValue(obj, pi16, null);
                    }
                    else if (str == "System.Int32")
                    {
                        int pi32 = Convert.ToInt32(value);
                        propertys[j].SetValue(obj, pi32, null);
                    }
                    else if (str == "System.Int64")
                    {
                        long pi64 = Convert.ToInt64(value);
                        propertys[j].SetValue(obj, pi64, null);
                    }
                    else if (str == "System.Byte")
                    {
                        byte pb = Convert.ToByte(value);
                        propertys[j].SetValue(obj, pb, null);
                    }
                    else
                    {
                        propertys[j].SetValue(obj, null, null);
                    }
                }

                list.Add(obj);
            }

            return list;
        }

        /// <summary>
        /// 导入Excel
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ms"></param>
        /// <param name="hasHeader"></param>
        /// <returns></returns>
        public static List<T> InputExcel<T>(Stream ms, bool hasHeader = false) where T : new()
        {
            List<T> list = new List<T> { };
            ms.Seek(0, SeekOrigin.Begin);
            IWorkbook workbook = null;
            try
            {
                //xlsx
                workbook = new XSSFWorkbook(ms);
            }
            catch (Exception)
            {
                //xls
                workbook = new HSSFWorkbook(ms);
            }



            ISheet sheet = workbook.GetSheetAt(0);
            IRow cellNum = sheet.GetRow(0);
            var propertys = typeof(T).GetProperties();
            string value = null;
            int num = cellNum.LastCellNum;

            for (int i = 0; i <= sheet.LastRowNum; i++)
            {
                if (hasHeader && i == 0)
                {
                    continue;
                }

                IRow row = sheet.GetRow(i);
                if (row == null || row.Cells.Count != num)
                {
                    continue;
                }
                var obj = new T();
                for (int j = 0; j < num; j++)
                {
                    //当输出类型属性个数小于文件列数时，跳出
                    if (propertys.Length - 1 < j)
                    {
                        break;
                    }

                    value = row.GetCell(j).ToString();
                    string str = (propertys[j].PropertyType).FullName;
                    if (str == "System.String")
                    {
                        propertys[j].SetValue(obj, value, null);
                    }
                    else if (str == "System.DateTime")
                    {
                        try
                        {
                            propertys[j].SetValue(obj, row.GetCell(j).DateCellValue, null);
                        }
                        catch (Exception e)
                        {
                            throw e;
                        }

                    }
                    else if (str == "System.Boolean")
                    {
                        bool pb = Convert.ToBoolean(value);
                        propertys[j].SetValue(obj, pb, null);
                    }
                    else if (str == "System.Int16")
                    {
                        short pi16 = Convert.ToInt16(value);
                        propertys[j].SetValue(obj, pi16, null);
                    }
                    else if (str == "System.Int32")
                    {
                        int pi32 = Convert.ToInt32(value);
                        propertys[j].SetValue(obj, pi32, null);
                    }
                    else if (str == "System.Int64")
                    {
                        long pi64 = Convert.ToInt64(value);
                        propertys[j].SetValue(obj, pi64, null);
                    }
                    else if (str == "System.Byte")
                    {
                        byte pb = Convert.ToByte(value);
                        propertys[j].SetValue(obj, pb, null);
                    }
                    else
                    {
                        propertys[j].SetValue(obj, null, null);
                    }
                }

                list.Add(obj);
            }

            return list;
        }

        /// <summary>
        /// 导入csv
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ms">数据流</param>
        /// <returns></returns>
        public static List<T> InputCSV<T>(Stream ms) where T : new()
        {
            List<T> list = new List<T> { };
            ms.Seek(0, SeekOrigin.Begin);

            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            StreamReader sr = new StreamReader(ms, Encoding.GetEncoding("GB2312"));
            var propertys = typeof(T).GetProperties();
            while (!sr.EndOfStream)
            {
                string[] values = sr.ReadLine().Split(',');
                var obj = new T();
                for (int i = 0; i < values.Length; i++)
                {
                    //当输出类型属性个数小于文件列数时，跳出
                    if (propertys.Length - 1 < i)
                    {
                        break;
                    }
                    string value = values[i].ToString();
                    string str = (propertys[i].PropertyType).FullName;
                    if (str == "System.String")
                    {
                        propertys[i].SetValue(obj, value, null);
                    }
                    else if (str == "System.DateTime")
                    {
                        DateTime pdt = Convert.ToDateTime(value, CultureInfo.InvariantCulture);
                        propertys[i].SetValue(obj, pdt, null);
                    }
                    else if (str == "System.Boolean")
                    {
                        bool pb = Convert.ToBoolean(value);
                        propertys[i].SetValue(obj, pb, null);
                    }
                    else if (str == "System.Int16")
                    {
                        short pi16 = Convert.ToInt16(value);
                        propertys[i].SetValue(obj, pi16, null);
                    }
                    else if (str == "System.Int32")
                    {
                        int pi32 = Convert.ToInt32(value);
                        propertys[i].SetValue(obj, pi32, null);
                    }
                    else if (str == "System.Int64")
                    {
                        long pi64 = Convert.ToInt64(value);
                        propertys[i].SetValue(obj, pi64, null);
                    }
                    else if (str == "System.Byte")
                    {
                        byte pb = Convert.ToByte(value);
                        propertys[i].SetValue(obj, pb, null);
                    }
                    else
                    {
                        propertys[i].SetValue(obj, null, null);
                    }
                }
                list.Add(obj);
            }
            return list;
        }
    }
}
