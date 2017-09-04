﻿
namespace ERP.Web.DomainService.Bill
{
    using ERP.Web.BLL;
    using ERP.Web.Common;
    using ERP.Web.DBUtility;
    using ERP.Web.Model;
    using System.Data;
    using System.Data.SqlClient;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;
    using ERP.Web.Interface;


    // TODO: Create methods containing your application logic.
    [EnableClientAccess()]
    public class DSWare_Bill_Transfer : DomainService
    {
        private IDAL bll = new BWare_Bill_Transfer();
        private IDALCheck bllCheck = new BWare_Bill_Transfer();
        private IDALUpdateEdit bllUpdateEdit = new BWare_Bill_Transfer();

        [Invoke]
        public bool Exists(string dbCode, int lgIndex, string vCode)
        {
            return bll.Exists(dbCode, lgIndex, vCode);
        }

        [Invoke]
        public string Add(string dbCode, int lgIndex, MWare_Bill_Transfer t)
        {
            return bll.Add(dbCode, lgIndex, t);
        }

        [Invoke]
        public void Update(string dbCode, int lgIndex, MWare_Bill_Transfer t)
        {
            bll.Update(dbCode, lgIndex, t);
        }

        [Invoke]
        public void UpdateEdit(string dbCode, int lgIndex, MWare_Bill_Transfer t)
        {
            bllUpdateEdit.UpdateEdit(dbCode, lgIndex, t);
        }

        [Invoke]
        public void Delete(string dbCode, int lgIndex, string vCode, string userCode, string userName)
        {
            bll.Delete(dbCode, lgIndex, vCode, userCode, userName);
        }

        [Invoke]
        public void Check(string dbCode, int lgIndex, string vCode, string userCode, string userName)
        {
            bllCheck.Check(dbCode, lgIndex, vCode, userCode, userName);
        }

        [Invoke]
        public void UnCheck(string dbCode, int lgIndex, string vCode, string userCode, string userName)
        {
            bllCheck.UnCheck(dbCode, lgIndex, vCode, userCode, userName);
        }
    }
}


