using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        if( digits.Length < span ){
            throw new ArgumentException("La stringa di cifre deve essere almeno di lunghezza di: " + span);
        }     
                long prodottoMax = 0;

        for(int i=0; i <= digits.Length - span; i++){
            
                    long prodottoAdesso = 1;

            for(int j = 0;j < span; j++){
                prodottoAdesso *= Convert.ToInt64(digits.Substring(i + j, 1));
            }
            if(prodottoAdesso > prodottoMax){
                prodottoMax = prodottoAdesso;
            }
        }
            return prodottoMax;

    }
}