using CdcSoftware.Pivotal.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP.EF.Data.AppDto.Request
{
    public class CreateCaseProcessExt : BaseDtoRequest
    {
        public Params Params { get; set; }
        public Id WFlowTemplateConfId { get; set; }
        public Id RecordId { get; set; }
        public int FormNumber { get; set; }
        public CreateCaseOperation Operation { get; set; }
        public CreateCaseDisposition Disposition { get; set; }
        public Id SourceWFlowId { get; set; }
        public string DispositionCode { get; set; }
        public string CurrencyCode { get; set; }
        public long? CompanyDefId { get; set; }
        public long? ContractDefId { get; set; }

        public CreateCaseProcessExt()
        { }

        public CreateCaseProcessExt(Params _params, Id wFlowTemplateConfId, int formNumber)
        {
            Operation = CreateCaseOperation.New;
            Disposition = CreateCaseDisposition.None;
            Params = _params;
            WFlowTemplateConfId = wFlowTemplateConfId;
            FormNumber = formNumber;
        }

        public CreateCaseProcessExt(Params _params, Id wFlowTemplateConfId, int formNumber, CreateCaseDisposition disposition)
        {
            Operation = CreateCaseOperation.New;
            Disposition = disposition;
            Params = _params;
            WFlowTemplateConfId = wFlowTemplateConfId;
            FormNumber = formNumber;
        }

        public CreateCaseProcessExt(Params _params, Id wFlowTemplateConfId, Id sourceWFlowId)
        {
            Operation = CreateCaseOperation.Copy;
            Disposition = CreateCaseDisposition.None;
            Params = _params;
            WFlowTemplateConfId = wFlowTemplateConfId;
            SourceWFlowId = sourceWFlowId;
        }

        public CreateCaseProcessExt(Params _params, Id sourceWFlowId, CreateCaseOperation operation, CreateCaseDisposition disposition, string dispositionCode)
        {
            Operation = operation;
            Disposition = disposition;
            Params = _params;
            SourceWFlowId = sourceWFlowId;
            DispositionCode = dispositionCode;
        }
    }

    public enum CreateCaseOperation
    {
        New,
        Copy
    }

    public enum CreateCaseDisposition
    {
        None,
        PaFromClick,
        LoanSell,
        Recall,
        BankTransferConfirmation,
        PpwFromProxyConnector,
        TransactionVerificationBiFromPC,
        SCACCChannelUnblock
    }
}
