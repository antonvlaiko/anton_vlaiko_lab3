using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3zavd2 {

    class Program {
        public static int FindByKey(string key, Dictionary<string, string>[] matrix) {
            int result = 0;
            for (int i = 0; i < matrix.Length; i++) {
                string value = " ";

                if (matrix[i].TryGetValue(key, out value)) {
                    Console.WriteLine("id: " + matrix[i]["id"] + " | success: " + matrix[i]["success"] + " | name: " + matrix[i]["name"]);
                    if (matrix[i]["success"] == "True") {
                        result++;
                    }
                }

            }
            return result;
        }

        static void Main(string[] args) {
            Dictionary<string, string>[] matrix = new Dictionary<string, string>[3] {
               new Dictionary<string, string>(),
               new Dictionary<string, string>(),
               new Dictionary<string, string>()
             };

            matrix[0].Add("id", "1");
            matrix[0].Add("success","True");
            matrix[0].Add("name", "Anton");
            matrix[1].Add("id", "2");
            matrix[1].Add("success","False");
            matrix[1].Add("name", "Antonisimo");
            matrix[2].Add("id", "3");
            matrix[2].Add("success","True");
            matrix[2].Add("name", "Ontonyo");

            Console.WriteLine(FindByKey("id", matrix));

        }
    }
}
