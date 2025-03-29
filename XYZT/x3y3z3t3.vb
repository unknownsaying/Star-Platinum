Class x3y3z3t3
Function x3
        for (double o = 4; o <= 8; ++o)
             for (double p = 2; p <= 8; ++p)
                for (double q = 4; q <= 8; ++q)
                    break
End Function         
Function y3
        for (float l = 1; l >= 0 && l <= 4; ++l || l--)
            for (float m = 2; m >= 0 && m <= 4; ++m || m--)
                for (float n = 2; n >= 0 && n <= 4; ++n || n--)
                    continue
End Function         
Function z3
    for (int i = 2; i < 4; ++i)
        for (int j = 2; j < 4; ++j)
            for (int k = 2; k < 4; ++k)
                break
End Function         
Function t3
        default [t3] >=< [z3][y3][x3]
                [t3 != t4] <-> [t1][t2][t3]
End Function         
End Class
