using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        /// <summary>
        /// Метод должен принимать идентификатор типа продукции, идентификатор типа материала, количество необходимой продукции для производства, ширину продукции и длину продукции
        /// </summary>
        /// <param name="productType"></param>
        /// <param name="materialType"></param>
        /// <param name="count"></param>
        /// <param name="width"></param>
        /// <param name="length"></param>
        /// <returns>возвращать целое число - количество необходимого сырья с учетом возможного брака сырья.</returns>
        public static int GetQuantityForProduct(int productType,int materialType,int count,float width,float length)
        {
            double mat = width * length;
            double brak = 0;
            switch (productType)
            {
                case 1:
                    mat = mat * 1.1;
                    break;
                case 2:
                    mat = mat * 2.5;
                    break;
                case 3:
                    mat = mat * 8.43;
                    break;
                    
            }
            mat = mat * count;
            switch (materialType)
            {
                case 1:
                    brak = mat * 0.003;
                    break;
                case 2:
                    brak = mat * 0.0012;
                    break;
            }

            int matireal = Convert.ToInt32(Math.Ceiling(mat + brak));


            return matireal;
        }
    }
}
