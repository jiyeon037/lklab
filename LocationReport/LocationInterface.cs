//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 도구를 사용하여 생성되었습니다.
//     런타임 버전:4.0.30319.42000
//
//     파일 내용을 변경하면 잘못된 동작이 발생할 수 있으며, 코드를 다시 생성하면
//     이러한 변경 내용이 손실됩니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Erp.BusinessManager
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using System.Runtime.Serialization;
    using System.ServiceModel.Web;
    using System.Data;
    
    
    // 테이블('Location')에 관한 Interface 클래스
    // 여기 코드는 용도에 맞게 변경하여 사용하시오
    // 
    [ServiceContract()]
    [ServiceKnownType(typeof(System.DBNull))]
    public interface LocationInterface
    {
        
        [OperationContract()]
        [WebGet()]
        [WebInvoke()]
        void Empty();

        [OperationContract()]
        [WebGet()]
        [WebInvoke()]
        LocationSet GetForLocationType(int locationType);

        [OperationContract()]
        [WebGet()]
        [WebInvoke()]
        LocationSet Get구매창고();

        [OperationContract()]
        [WebGet()]
        [WebInvoke()]
        DataSet GetLocationFromNo(int locationNo);

        [OperationContract()]
        [WebGet()]
        [WebInvoke()]
        DataSet GetLocationData(int locationNo);

        [OperationContract()]
        [WebGet()]
        [WebInvoke()]
        DataSet GetLocationName();


    }
}
