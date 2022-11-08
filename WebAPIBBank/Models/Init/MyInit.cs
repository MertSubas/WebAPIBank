using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebAPIBBank.Models.Context;
using WebAPIBBank.Models.Entities;

namespace WebAPIBBank.Models.Init
{
    public class MyInit:CreateDatabaseIfNotExists<MyContext>
    {protected override void Seed(MyContext context)
        {
            CardInfo ci=new CardInfo();
            ci.CardUserName = "Mert Subas";
            ci.CardNumber = "0000 0000 0000 0000";
            ci.CardExpiryYear = 2024;
            ci.CardExpiryMonth = 12;
            ci.SecurityNumber = "222";
            ci.Limit = 50000;
            ci.Balance = 50000;
            context.Cards.Add(ci);
            context.SaveChanges();
        }
    }
}