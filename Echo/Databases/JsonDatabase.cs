﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBHandler
{
    class JsonDatabase : Database
    {
        public String name { get; }
        private String fileSource;
        private Dictionary<String, String> data;

        public JsonDatabase(String dbName, String fileSource )
        {
            name = dbName;
            this.fileSource = fileSource;
            data = new Dictionary<string, string>();
            load();
        }

        public void add(DB_Object newItem, bool saveAfterAdd = true)
        {
            if(newItem.ID == "")
            {
                newItem.ID = generateDatabaseID();
            }

            String serialized = JsonConvert.SerializeObject(newItem);

            try
            {   //add if not in list
                data.Add(newItem.ID, serialized);
            }
            catch (ArgumentException)
            {   //replace if already in list
                data[newItem.ID] = serialized;
            }

            if(saveAfterAdd)
            {
                save();
            }
        }

        public void remove(String ID)
        {
            data.Remove(ID);
        }

        public String generateDatabaseID()
        {
            int dbSize = data.Count;
            return (data.Count + 1).ToString();
        }

        public T getObject<T> (String ID)
        {
            T temp = JsonConvert.DeserializeObject<T>(data[ID]);
            return temp;
        }

        private void load()
        {
            if(File.Exists(fileSource))
            {
                System.IO.StreamReader file = new System.IO.StreamReader(fileSource);
                string line;
                while((line = file.ReadLine()) != null)
                {
                    Customer customer = JsonConvert.DeserializeObject<Customer>(line);
                    add(customer, false);
                }
                file.Close();
            }
        }

        private void save()
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(fileSource, false);
            foreach( String key in data.Keys)
            {
                file.WriteLine(data[key]);
            }
            file.Close();
        }

        public void debug<T>() where T : DB_Object
        {
            foreach( String key in data.Keys)
            {
                T temp = JsonConvert.DeserializeObject<T>(data[key]);
                temp.debug();
            }
        }
    }
}
