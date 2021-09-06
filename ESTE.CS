/*
int hhInicial=0, hhFinal=0, mmInicial=0, mmFinal=0, hFIM=0, hINI=0, minFIM=0, minINI=0, HORAS=0, MINUTOS=0; 

if(hhInicial < hhFinal && mmInicial < mmFinal) ?                            Math.Abs(hhInicial - hhFinal) :
if(hhInicial < hhFinal && mmInicial > mmFinal) ?                            Math.Abs(hhInicial - hhFinal) - 1 :
if(hhInicial < hhFinal && mmInicial == mmFinal) ?                           Math.Abs(hhInicial - hhFinal) :
if(hhInicial > hhFinal && mmInicial < mmFinal) ?                            24 - Math.Abs(hhInicial - hhFinal) :
if(hhInicial > hhFinal && mmInicial > mmFinal) ?                            24 - Math.Abs(hhInicial - hhFinal) - 1 :
if(hhInicial == hhFinal && mmInicial < mmFinal) ?                           Math.Abs(hhInicial - hhFinal) :  
if(hhInicial == hhFinal && mmInicial > mmFinal) ?                           23 : 
                                                                            24 - Math.Abs(hhInicial - hhFinal); 
                            



    "7 10 10 7" + "7 10 10 10"          "7 10 10 7" + "7 10 7 7" 
if((hINI < hFIM && minFIM <= minINI)||(hINI <= hFIM && minFIM < minINI))    HORAS = hFIM - hINI; MINUTOS = minFIM - minINI;
    "7 7 7 7"
if (hINI == hFIM && minFIM == minINI)                                       HORAS = 24; MINUTOS = 0;
    "7 7 7 10"
if (hINI == hFIM && minFIM > minINI)                                        HORAS = 23; MINUTOS = minFIM + (60 - minINI);
    "7 7 10 10"
if (hINI < hFIM && minFIM > minINI)                                         HORAS = hFIM - hINI - 1; MINUTOS = minFIM + (60 - minINI);
    "10 7 7 10"
if (hINI > hFIM && minFIM > minINI)                                         HORAS = hFIM + (24 - hINI) - 1; MINUTOS = minFIM + (60 - minINI);
    "10 10 7 7" + "10 10 7 10" 
if (hINI > hFIM && minFIM <= minINI)                                        HORAS = hFIM + (24 - hINI); MINUTOS = minFIM - minINI;


 "7 10 10 7",   //O JOGO DUROU 2 HORA(S) E 57 MINUTO(S)
 "7 10 10 10",  //O JOGO DUROU 3 HORA(S) E 0 MINUTO(S) 
 "7 10 10 7",   //O JOGO DUROU 2 HORA(S) E 57 MINUTO(S)
 "7 10 7 7",    //O JOGO DUROU 23 HORA(S) E 57 MINUTO(S)
 "7 7 7 7",     //O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)
 "7 7 7 10",    //O JOGO DUROU 0 HORA(S) E 3 MINUTO(S)
 "7 7 10 10",   //O JOGO DUROU 3 HORA(S) E 3 MINUTO(S) 
 "10 7 7 10",   //O JOGO DUROU 21 HORA(S) E 3 MINUTO(S)
 "10 10 7 7",   //O JOGO DUROU 20 HORA(S) E 57 MINUTO(S)
 "10 10 7 10",  //O JOGO DUROU 21 HORA(S) E 0 MINUTO(S)  
 */