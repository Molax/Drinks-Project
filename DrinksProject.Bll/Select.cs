using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinksProject.Dto;
using DrinksProject.Dal;

namespace DrinksProject.Bll
{
    public class Select
    {
        public static DrinksProject.ViewModel.SelectAllSizes SelectAllSizes()
        {
            ViewModel.SelectAllSizes AllSizes = new ViewModel.SelectAllSizes();

            List<Dto.Size> Sizes = Dal.Size.SelectAllSizes();

            return AllSizes;
        }
    }
}
