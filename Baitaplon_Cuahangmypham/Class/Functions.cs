﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitaplon_Cuahangmypham.Class
{
    internal class Functions
    {
            public static SqlConnection Conn;  
            public static string connString;   
            public static void Connect()
        {

            // connString = "Data Source=LAPTOP-O3TH1H5S\\SQLEXPRESS;Initial Catalog=CuaHangMyPham;Integrated Security=True;Encrypt=False"; 

            //connString = "Data Source=XIAODOU;Initial Catalog=CuaHangMyPham;Integrated Security=True;Encrypt=False";
            //connString = "Data Source=LAPTOP-8CQUN76N\\sqlexpress;Initial Catalog=CuaHangMyPham;Integrated Security=True;Encrypt=False";
            //connString = "Data Source=LAPTOP-9FSA2OM9\\SQLEXPRESS;Initial Catalog=CuaHangMyPham;Integrated Security=True;Encrypt=False";
            connString = "Data Source=DESKTOP-NM815JH\\SQLEXPRESS;Initial Catalog=CuaHangMyPham;Integrated Security=True;Encrypt=False";
            Conn = new SqlConnection();                 
            Conn.ConnectionString = connString;         
            Conn.Open();                                
            }
            public static DataTable GetDataToTable(string sql)
            {
                SqlDataAdapter Mydata = new SqlDataAdapter();   // Khai báo
                                                                // Tạo đối tượng Command thực hiện câu lệnh SELECT        
                Mydata.SelectCommand = new SqlCommand();
                Mydata.SelectCommand.Connection = Functions.Conn;   // Kết nối CSDL
                Mydata.SelectCommand.CommandText = sql; // Gán câu lệnh SELECT
                DataTable table = new DataTable();    // Khai báo DataTable nhận dữ liệu trả về
                Mydata.Fill(table);     //Thực hiện câu lệnh SELECT và đổ dữ liệu vào bảng table
                return table;
            }
            public static bool CheckKey(string sql)
            {
                SqlDataAdapter Mydata = new SqlDataAdapter(sql, Functions.Conn);
                DataTable table = new DataTable();
                Mydata.Fill(table);
                if (table.Rows.Count > 0)
                    return true;
                else
                    return false;
            }

            public static void RunSql(string sql)
            {
                SqlCommand cmd;                     // Khai báo đối tượng SqlCommand
                cmd = new SqlCommand();          // Khởi tạo đối tượng
                cmd.Connection = Functions.Conn;      // Gán kết nối
                cmd.CommandText = sql;            // Gán câu lệnh SQL
                try
                {
                    cmd.ExecuteNonQuery();        // Thực hiện câu lệnh SQL
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                cmd.Dispose();
                cmd = null;
            }
            public static void RunSqlDel(string sql)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Functions.Conn;
                cmd.CommandText = sql;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Dữ liệu đang được dùng, không thể xóa...", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                cmd.Dispose();
                cmd = null;
            }
            public static bool IsDate(string d)
            {
                string[] parts = d.Split('/');
                if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) && (Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1990))
                {
                    return true;
                }
                else return false;
            }
            public static string ConvertDatetime(string d)  // d: datetime
            {
                string[] parts = d.Split('/');
                string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
                return dt;
            }
        public static void FillCombo(string sql, ComboBox cbo, string ma, string ten)
            {
                SqlDataAdapter Mydata = new SqlDataAdapter(sql, Class.Functions.Conn);
                DataTable table = new DataTable();
                Mydata.Fill(table);
                cbo.DataSource = table;

                cbo.ValueMember = ma;    // Truong gia tri
                cbo.DisplayMember = ten;    // Truong hien thi
            }
            public static string getfieldvalues(string sql) //lấy các trường trong bảng mình k select
            {
                string ma = "";
                SqlCommand cmd = new SqlCommand(sql, Functions.Conn);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ma = reader.GetValue(0).ToString();
                }
                reader.Close();
                return ma;
        }
        public static bool Checkey(string sql)
        {
            SqlDataAdapter mydata = new SqlDataAdapter(sql, Functions.Conn);
            DataTable table = new DataTable();
            mydata.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Hàm chuyển đổi từ chữ sang số
        public static string ChuyenSoSangChu(string sNumber)
        {
            int mLen;
            string mTemp = "";
            string[] mNumText;

            // Xóa các dấu "," nếu có
            sNumber = sNumber.Replace(",", "");
            mNumText = "không;một;hai;ba;bốn;năm;sáu;bảy;tám;chín".Split(';');
            mLen = sNumber.Length - 1; // Trừ 1 vì thứ tự đi từ 0

            for (int i = 0; i <= mLen; i++)
            {
                int mDigit;
                if (int.TryParse(sNumber.Substring(i, 1), out mDigit))
                {
                    mTemp = mTemp + " " + mNumText[mDigit];
                    if (mLen == i) // Chữ số cuối cùng không cần xét tiếp
                        break;

                    switch ((mLen - i) % 9)
                    {
                        case 0:
                            mTemp = mTemp + " tỷ";
                            if (sNumber.Substring(i + 1, 3) == "000")
                                i = i + 3;
                            if (sNumber.Substring(i + 1, 3) == "000")
                                i = i + 3;
                            if (sNumber.Substring(i + 1, 3) == "000")
                                i = i + 3;
                            break;
                        case 6:
                            mTemp = mTemp + " triệu";
                            if (sNumber.Substring(i + 1, 3) == "000")
                                i = i + 3;
                            if (sNumber.Substring(i + 1, 3) == "000")
                                i = i + 3;
                            break;
                        case 3:
                            mTemp = mTemp + " nghìn";
                            if (sNumber.Substring(i + 1, 3) == "000")
                                i = i + 3;
                            break;
                        default:
                            switch ((mLen - i) % 3)
                            {
                                case 2:
                                    mTemp = mTemp + " trăm";
                                    break;
                                case 1:
                                    mTemp = mTemp + " mươi";
                                    break;
                            }
                            break;
                    }
                }
            }
            //Loại bỏ trường hợp x00
            mTemp = mTemp.Replace("không mươi không ", "");
            mTemp = mTemp.Replace("không mươi không", "");
            //Loại bỏ trường hợp 00x
            mTemp = mTemp.Replace("không mươi ", "linh ");
            //Loại bỏ trường hợp x0, x>=2
            mTemp = mTemp.Replace("mươi không", "mươi");
            //Fix trường hợp 10
            mTemp = mTemp.Replace("một mươi", "mười");
            //Fix trường hợp x4, x>=2
            mTemp = mTemp.Replace("mươi bốn", "mươi tư");
            //Fix trường hợp x04
            mTemp = mTemp.Replace("linh bốn", "linh tư");
            //Fix trường hợp x5, x>=2
            mTemp = mTemp.Replace("mươi năm", "mươi lăm");
            //Fix trường hợp x1, x>=2
            mTemp = mTemp.Replace("mươi một", "mươi mốt");
            //Fix trường hợp x15
            mTemp = mTemp.Replace("mười năm", "mười lăm");
            //Bỏ ký tự space
            mTemp = mTemp.Trim();
            //Viết hoa ký tự đầu tiên
            mTemp = mTemp.Substring(0, 1).ToUpper() + mTemp.Substring(1) + " đồng";
            return mTemp;
        }
        //Hàm tạo khóa có dnagj: TientoNgaythangnam_giophutgiay
        public static string CreateKey(string tiento)
        {
            string key = tiento;

            // Lấy ngày tháng hiện tại và chuyển đổi thành một chuỗi có định dạng "yyyyMMdd"
            string date = DateTime.Now.ToString("ddMMyyyy");
            key += date;
            // Lấy giờ phút giây hiện tại trong định dạng 24 giờ "HHmmss"
            string time = DateTime.Now.ToString("HHmmss");
            key += time;

            return key;
        }
        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }

        //public static string createkey(string tiento)
        //{
        //    string key = tiento;
        //    string[] partsDay;
        //    partsDay = DateTime.Now.ToShortDateString().Split('/');
        //    //Ví dụ 07/08/2009
        //    string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
        //    key = key + d;
        //    string[] partsTime;
        //    partsTime = DateTime.Now.ToLongTimeString().Split(':');
        //    //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
        //    if (partsTime[2].Substring(3, 2) == "PM")
        //        partsTime[0] = ConvertTimeTo24(partsTime[0]);
        //    if (partsTime[2].Substring(3, 2) == "AM")
        //        if (partsTime[0].Length == 1)
        //            partsTime[0] = "0" + partsTime[0];
        //    //Xóa ký tự trắng và PM hoặc AM
        //    partsTime[2] = partsTime[2].Remove(2, 3);
        //    string t;
        //    t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
        //    key = key + t;
        //    return key;
        //}
    }
}

