﻿using System;
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
        public static List<DrinksProject.ViewModel.SelectAllSizes> SelectAllSizes()
        {
            List<ViewModel.SelectAllSizes> AllSizes = new List<ViewModel.SelectAllSizes>();

            List<Dto.Size> SizeDTO  = new List<Dto.Size>();

            SizeDTO = Dal.Size.SelectAllSizes();

            foreach (var item in SizeDTO)
            {
                AllSizes.Add(new ViewModel.SelectAllSizes {PK_SIZE = item.PK_SIZE ,SIZETYPE = item.SIZETYPE });
            }

            return AllSizes;
        }

        public static List<DrinksProject.ViewModel.SelectAllTypes> SelectAllTypes()
        {
            List<ViewModel.SelectAllTypes> AllTypes = new List<ViewModel.SelectAllTypes>();

            List<Dto.Type> TypeDTO = new List<Dto.Type>();

            TypeDTO = Dal.Type.SelectAllTypes();

            foreach (var item in TypeDTO)
            {
                AllTypes.Add(new ViewModel.SelectAllTypes { NAME = item.NAME, PK_TYPE = item.PK_TYPE });
            }

            return AllTypes;
        }
    }
}
