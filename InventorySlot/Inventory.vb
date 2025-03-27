Imports System.Math
Sub Inventory
Function x1y1z1t1
const x1 = "!!!!!!!!"
const y1 = "@@@@@@@@"
const z1 = "########"
const t1 = "$$$$$$$$"
   do (x1 * y1 * z1) / t1;
   for(x1=0;x1<=1;++x1)
   for(y1=0;y1<=1;++y1)
   for(z1=0;z1<=1;++z1)
   for(t1=0;t1<=1;++t1)
   while(x1 % y1 %z1)
   goto Inventory
End Function
Function x2y2z2t2
const x2 = "~~~~~~~~"
const y2 = "&&&&&&&&"
const z2 = "||||||||"
const t2 = "========"
   do (x2 * y2 * z2) / t2;
   for(x2=0;x2<=2;x2++)
   for(y2=0;y2<=2;y2++)
   for(z2=0;z2<=2;z2++)
   for(t2=0;t2<=2;t2++)
   while(x1 %y1 %z1)
    goto Inventory
End Function
Function x3y3z3t3
const x3 = "<><><><>"
const y3 = "()()()()"
const z3 = "[][][][]"
const t3 = "{}{}{}{}"
   do (x3 * y3 * z3) / t3;
   for(x3=0;x3<=4;++x3)
   for(y3=0;y3<=4;++y3)
   for(z3=0;z3<=4;++z3)
   for(t3=0;t3<=4;++t3)
   while(x1 %y1 %z1)
    goto Inventory
End Function 
Function x4y4z4t4
const x4 = "++++++++"
const y4 = "--------"
const z4 = "********"
const t4 = "%%%%%%%%"
   do (x4 * y4 * z4) / t4;
   for(x4=0;x4<=8;x4++)
   for(y4=0;y4<=8;y4++)
   for(z4=0;z4<=8;z4++)
   for(t4=0;t4<=8;t4++)
   while(x4 % y4 %z4)
    goto Inventory
End Function
End Sub