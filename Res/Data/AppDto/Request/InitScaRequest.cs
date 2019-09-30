using CdcSoftware.Pivotal.Engine;
using PP.EF.Data.AppDto.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PP.EF.Data.AppDto.Response
{
    public class InitScaRequest : BaseDtoRequest
    {
        public string type { get; set; }
        public bool callDirection { get; set; }
        public string cif { get; set; }
        public Id a_SCA_Autoryzacja_Id { get; set; }
        public Id a_Wflow_Id { get; set; }
        public Id companyId { get; set; }

        public Id a_Wflow_template_conf_Id { get; set; }

        public InitScaRequest(string type_, bool callDirection_, string cif_, Id a_SCA_Autoryzacja_Id_, Id a_Wflow_Id_, Id companyId_, Id a_Wflow_template_conf_Id_)
        {
            type = type_;
            callDirection = callDirection_;
            cif = cif_;
            a_SCA_Autoryzacja_Id = a_SCA_Autoryzacja_Id_;
            a_Wflow_Id = a_Wflow_Id_;
            companyId = companyId_;
            a_Wflow_template_conf_Id = a_Wflow_template_conf_Id_;
        }
    }
}
