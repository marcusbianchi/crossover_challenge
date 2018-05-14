using System;

namespace crossover_challenge {
    class Program {
        /*
         * Complete the function below.
         * DO NOT MODIFY CODE OUTSIDE THIS FUNCTION!
         */
        static int[] rearrange (int[] elements) {

            int temp = 0;
            for (int pass = 1; pass <= elements.Length - 2; pass++) {
                for (int i = 0; i <= elements.Length - 2; i++) {
                    int valueCount = Convert.ToString (elements[i], 2).Split ("1").Length - 1;
                    int elementCount = Convert.ToString (elements[i + 1], 2).Split ("1").Length - 1;
                    if (valueCount > elementCount) {
                        temp = elements[i + 1];
                        elements[i + 1] = elements[i];
                        elements[i] = temp;
                    } else if (valueCount == elementCount && elements[i] > elements[i + 1]) {
                        temp = elements[i + 1];
                        elements[i + 1] = elements[i];
                        elements[i] = temp;
                    }
                }
            }
            int count = 0;
            for (int i = 0; i < elements.Length - 1; i++) {
                if (elements[i] != elements[i + 1]) {
                    //res[count] = elements[i];
                    count++;
                }
            }

            int[] res = new int[count + 1];
            count = 0;
            for (int i = 0; i < elements.Length - 1; i++) {
                if (elements[i] != elements[i + 1]) {
                    res[count] = elements[i];
                    count++;
                }
            }
            res[count] = elements[elements.Length - 1];
            Console.WriteLine (string.Join (",", res));

            return res;

        }
        // DO NOT MODIFY CODE OUTSIDE THE ABOVE FUNCTION!

        static void Main (String[] args) {
            int[] res;

            // int _elements_size = 0;
            // _elements_size = Convert.ToInt32 (Console.ReadLine ());
            // int[] _elements = new int[_elements_size];
            // int _elements_item;
            // for (int _elements_i = 0; _elements_i < _elements_size; _elements_i++) {
            //     _elements_item = Convert.ToInt32 (Console.ReadLine ());
            //     _elements[_elements_i] = _elements_item;
            // }

            res = rearrange (new int[] { 0 });
            // for (int res_i = 0; res_i < res.Length; res_i++) {
            //     Console.WriteLine (res[res_i]);
            // }
        }
    }
}