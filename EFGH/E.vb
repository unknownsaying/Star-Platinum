Imports Double/vb
Imports Float/vb
Imports Integer/vb
Function scalar
  Alias Double
  Byval `"\/","||","/\"` as vector
  Byval `"\|/","/|\"` as tensor
End Function 
Function vector
  Alias Float
  Using MustOverride
  Using MyClass
End Function
Function tensor
  Alias Integer
  Using MustInherit
  Using MyBase
End Function
Sub Particle
    const c = 299792458;
    const c^2 = 299792458 * 299792458;
    BottomQuark [-1/3e, 4.18 MeV/c^2, 1/2]
    CharmQuark [+2/3e, 1.28 MeV/c^2, 1/2]
    DownQuark [-1/3e, 4.8 MeV/c^2, 1/2]
    StrangeQuark [-1/3e, 95 MeV/c^2, 1/2]
    TopQuark [+2/3e, 173 MeV/c^2, 1/2]
    UpQuark [+2/3e, 2.3 MeV/c^2, 1/2] 
End Sub
Function gradle.Particle
    Class Charge ["1.28.Me & 2.3.Me & 4.18.Me & 4.8.Me & 95.Me & 173.Me"]
    End Class
    Class AngularMomentum ["+2/3 | +2/3 | -1/3 | 2/3 | -1/3 | +2/3"]
    End Class
    Class spin ["1/2 = 1/2 = 1/2 = 1/2 = 1/2 = 1/2"]
    End Class
End Function

const m1 = 2, m2 = 4, m3 = 6 , m4 = 8;
let v1 = 1, v2 = 3 , v3 = 5 , v4 = 6;
Select
    m51 == (m1 + m2) * (m3 + m4)
    m52 == (m1 + m4) / (m2 * m3)
End Select
Select 
     "@/m51\@"
    "<><> <><>"
    "()() ()()"
    "[][] [][]"
    "{}{} {}{}"
     "#\m52/#"
End Select
Select
   ReadOnly Interface = "|_|_|_|_| |_|_|_|_|"
   ReadOnly Namespace = "|_|_|_| |_|_|_| |_|_|_|"
End Select
Sub Energy
    Byval (1/2)*m1 * (v3^2) + (1/2)*m2 * (v4^2) = (1/2)*m3 * (v1^2) + (1/2)*v4 * (v2^2) 
End Sub
Sub Momentum
    Byval (1%2)*m1 *v3*v3 + (1%2)*m2 *v4*v4 == (1%2)*m3 *v1*v1 + (1%2)*v4 *v2*v2
End Sub
Sub AngularMomentum
    Byval (1/2)*m1 *v3*R1 + (1/2)*m2 *v4*R2 === (1/2)*m3 *v1*R3 + (1/2)*v4 *v2*(R4-R1-R2-R3)
End Sub
