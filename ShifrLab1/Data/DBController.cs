using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace ShifrLab1.Data
{
    class DBController
    {
        public List<DataModel> _listOfData;
        readonly string _dbPath;

        public DBController()
        {
            _listOfData = new List<DataModel>();
            _dbPath = Program.dbPath;

            //SaveData();
            if (!File.Exists(_dbPath))
            {
                using (File.Create(_dbPath));
                _listOfData.Add(new DataModel() { login = "admin", password = "", isBlocked = false, passwordIsLimited = false }); // adding user to DateBase
                SaveData();
            }
            GetData();
        }

        public void SaveData()
        {
            string dataJson = JsonSerializer.Serialize(_listOfData);
            dataJson = encodedDataToStr(Program.encrController.encryptData(dataJson));

            using (StreamWriter writer = new StreamWriter(_dbPath, false))
            {
                writer.WriteLine(dataJson);
            }
        }

        public void GetData()
        {
            string dataJson = "";
            using (StreamReader reader = new StreamReader(_dbPath))
            {
                dataJson = reader.ReadToEnd();
            }
            if (dataJson != "")
            {
                dataJson = Program.encrController.decryptData(encodedDataToByte(dataJson));
                _listOfData = JsonSerializer.Deserialize<List<DataModel>>(dataJson);
            }
        }

        private string encodedDataToStr(byte[] encodedData)
        {
            string encodedDataStr = string.Empty;

            foreach (var x in encodedData)
            {
                if (encodedDataStr == "")
                {
                    encodedDataStr = $"{Convert.ToInt32(x)}";
                }
                else
                    encodedDataStr = $"{encodedDataStr}|{Convert.ToInt32(x)}";
            }
            return encodedDataStr;
        }

        private byte[] encodedDataToByte(string encodedDataStr)
        {

            int[] intByte = encodedDataStr.Split('|').Select(_ => int.Parse(_, NumberStyles.Integer)).ToArray();
            byte[] encodedData = new byte[intByte.Length];
            for (var i = 0; i < intByte.Length; i++)
            {
                encodedData[i] = (byte)intByte[i];
            }
            return encodedData;
        }

    }
}
