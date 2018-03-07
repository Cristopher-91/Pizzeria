//Class responsible for uploading types of pizza from .txt file
using System;
using System.Collections.Generic;

namespace Pizzeria
{
    class Reader
    {
        private string path = "C:\\Users\\P0021009\\Desktop\\Pizzas.txt";
        private string line;

        public List<string> positions = new List<string>();

        public List<string> Read()
        {
            using (System.IO.StreamReader SR = new System.IO.StreamReader(path))
            {
                while ((line = SR.ReadLine()) != null)
                {
                    positions.Add(line);
                }              
                SR.Close();
            }
            
            return positions;
        }
    }
}
