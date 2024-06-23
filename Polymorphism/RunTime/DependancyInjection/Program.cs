using System;
using System.Collections.Generic;
namespace DependancyInjection;

public class Program{
    public static void Main(string[] args)
    {
        CCAccount ccAccount=new CCAccount();
        ccAccount.Name="Yathav";
        ccAccount.AccountNumber=123456;
        ccAccount.Balance=1000;

        SBAccount sBAccount=new SBAccount();

        sBAccount.Name="krish";
        sBAccount.AccountNumber=56789;
        sBAccount.Balance=500;

        List<CCAccount> ccList=new List<CCAccount>();
        ccList.Add(ccAccount);
        List<SBAccount> sbList=new List<SBAccount>();
        sbList.Add(sBAccount);

        List<IAccount> accounts=new List<IAccount>();
        accounts.Add(ccAccount);
        accounts.Add(sBAccount);

        
    }
}