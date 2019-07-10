using System;
using System.Collections.Generic;
using System.Text;

namespace EmailLibrary.Models
{
    public class Attachmes
    {
        public int Length { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public byte[] Bytes { get; set; }
        public string ContentType { get; set; }
    }
}
