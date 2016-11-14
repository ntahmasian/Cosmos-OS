using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;
//using Cosmos.Hardware;
//using System.Globalization;

namespace LatestCosmosKernel
{
    public class File
    {
        //DateTime datde = DateTime.Now;
        String name;
        String extension;
        String date;
        Int32 size;
        Int32 line;
        ArrayList data;

        public File(String n, String e)
        {
            name = n;
            extension = e;
            date = "11/03/2016" /* + Cosmos.Hardware.RTC.Month + "/" + Cosmos.Hardware.RTC.DayOfTheMonth + "/" + Cosmos.Hardware.RTC.Year*/;
            size = 0;
            line = 0;
            data = new ArrayList();
        }

        public File(File file)
        {
            name = file.name;
            extension = file.extension;
            date = file.date;
            size = file.size;
            line = 0;
            data = file.data;
        }

        public void setData(String date)
        {
            data.Add(date);
            size += date.Length;
        }

        public String getName()
        {
            return name;
        }

        public String getExtension()
        {
            return extension;
        }

        public String getDate()
        {
            return date;
        }

        public Int32 getSize()
        {
            return size;
        }

        public Int32 getLine()
        {
            return line;
        }

        public ArrayList getData()
        {
            return data;
        }

        public void setLine(Int32 num)
        {
            line = num;
        }

        public void resetLine()
        {
            line = 0;
        }

        public void incrementLine()
        {
            line++;
        }
    }
}