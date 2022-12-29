using System;
namespace RoadBook.CsharpBasic.Chapter05.Examples.model
{
    /// <summary>
    /// 은행계좌
    /// </summary>
    

    public class BankAccount
    {
       ///<summary>
       ///고유이름
       ///</summary>
       public string BankName { get; set; }
        ///<summary>
        ///개설자이름
        ///</summary>
        public string UserName { get; set; }
        ///<summary>
        ///잔액
        ///</summary>
       
        public int Money { get; set; }
    }
}

