﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SciencesStudies.Model;

namespace SciencesStudies
{
    class EnglishBooksDalUser
    {
        //Listeleme fonksiyonu :
        public List<EnglishBooks> GetAllEnglishBooks()
        {
            using (InstituteDbEntities context = new InstituteDbEntities())
            {
                return context.EnglishBooks.ToList();
            }
        }
    }
}
