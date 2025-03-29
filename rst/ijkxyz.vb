Imports System.Math
Declare Module x1{}
Declare Module y1{}
Declare Module x2{}
Declare Module y2{}
Function ijkxyz
     ijk = sin(i) * (x1 + x2) + cos(j) * (y1 + y2)
     ijk = cos(j) * (x1 - x2) + sin(i) * (y1 - y2)
     ijk = sin(i) * (x1 + x2) + sin(j) * (y1 + y2) + sin(k) * (z1 + z2)
     ijk = cos(i) * (x1 + x2) + cos(j) * (y1 + y2) + cos(k) * (z1 + z2)
End Function
