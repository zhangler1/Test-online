﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{



    public class teacher
    {
        public DataTable get_user_info(string  teacherId)
        {
            return Ado.SqlHelper.ExecuteDataTable("select * from TeacherLogin where teacherId = @teacherId ", new System.Data.SqlClient.SqlParameter("@teacherId", teacherId));
        }

    }

}
