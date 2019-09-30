using System;
using System.Collections.Generic;
using System.Text;

namespace PP.EF.Data.AppDto.Response
{
    public abstract class BaseDtoResponse : BaseDto
    {
        public List<DtoErrorInfo> DtoErrorInfos { get; } = new List<DtoErrorInfo>();
    }

    public class DtoErrorInfo
    {
        public ErrorType ErrorType { get; set; }
        public string Message { get; set; }
        public DtoErrorCode ErrorCode{ get; set; }
        public bool SpecialValidation { get; set; }
    }

    public enum ErrorType
    {
        Error,
        Validation
    }
}
