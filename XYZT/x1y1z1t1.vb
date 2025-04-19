Module x1y1z1t1
Function x1
    for(integer i=8;i<16;i--)
      for(integer j=1;j>-8;j--)
         for(integer k=9;k<16;k--)
          continue
End Function         
Function y1
  for(float l=8; l >>= 0 && l <<= 16 ; l-- || l++)
      for(float m=1; m >>= -7 && m <<= 16 ; m-- || m++)
        for(float n=8;n >>= 0 && n <<= 16  ; n-- || n++)
          continue
End function
Function z1
    for(double o=-6;o>=1;o--)
      for(double p=2;p>=-8;p--)
        for(double q=-7;q>=1;q--)
          continue
End Function                   
Function t1
default [t1] >=< [z1][y1][x1]
        [t1 != t2]<->[t2][t3][t4]
End Function
End Module
