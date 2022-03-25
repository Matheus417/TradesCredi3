﻿using TesteCredit.Interfaces;

namespace TesteCredit.ClassesConretas
{
    static class ConstructorTrades
    {
        private const int NUMBERPARAMETERSDEFAULT = 3;
        private static int NumeroEntradas;
        public static AbstractTrade BuildTrades(string pEntrada)
        {
            NumeroEntradas = pEntrada.Split(Utils.elementsSeparated).Length;
            AbstractTrade wTradeBase = new Trade(pEntrada);
            if (NumeroEntradas != NUMBERPARAMETERSDEFAULT)
            {
                if ((NumeroEntradas == TradeExposed.NumberParameters) && (Validations.validTradeExposed(pEntrada)) )
                    wTradeBase = new TradeExposed(pEntrada, (Trade)wTradeBase);
                else return new TradeInvalid(pEntrada);
            }
            return wTradeBase;
        }
    }
}
