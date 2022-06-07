'   Politecnico di Milano (2022)
'
'   Bachelor's degree in chemical engineering
'
'   This code was developed and tested by Elia Ferretti
'
'   You can redistribute the code and/or modify it
'   Whenever the code is used to produce any publication or document,
'   reference to this work and author should be reported
'   No warranty of fitness for a particular purpose is offered
'   The user must assume the entire risk of using this code
'
'------------------------------------------------------------------------------------------------------------









Function zetaL(A As Double, B As Double, c As Double, d As Double) As Double
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim aus As Double
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    pig = 3.14159265353589
    
    beta = B / A
    gamma = c / A
    delta = d / A
     
    p = gamma - (beta) ^ (2) / 3
    q = 2 * (beta) ^ (3) / 27 - beta * gamma / 3 + delta
    det = (q) ^ (2) / 4 + (p) ^ (3) / 27
   
    If det >= 0 Then
        zeta1 = -q / 2 + (det) ^ (0.5)
        zeta2 = -q / 2 - (det) ^ (0.5)
        Dim coeff1 As Integer
        Dim coeff2 As Integer
        coeff1 = 1
        coeff2 = 1
        If zeta1 < 0 Then
            zeta1 = -zeta1
            coeff1 = -1
        End If
        If zeta2 < 0 Then
            zeta2 = -zeta2
            coeff2 = -1
        End If
        'unterzo = 1 / 3
        u = coeff1 * (zeta1) ^ (1 / 3)
        v = coeff2 * (zeta2) ^ (1 / 3)
        y1 = u + v
        'y = (-(q) / 2 + (det) ^ (0.5)) ^ (1 / 3) + (-(q) / 2 - (det) ^ (0.5)) ^ (1 / 3)
        aus = y1 - beta / 3
    Else
        If q < 0 Then
            teta = Atn(-2 * (-det) ^ (0.5) / q)
        Else
            teta = pig + Atn(-2 * (-det) ^ (0.5) / q)
        End If
      
        y1 = 2 * (-p / 3) ^ (0.5) * Cos(teta / 3)
        y2 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 2 * pig) / 3)
        y3 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 4 * pig) / 3)
        zeta1 = y1 - beta / 3
        zeta2 = y2 - beta / 3
        zeta3 = y3 - beta / 3
        aus = zeta1
        If zeta2 < aus Then
            aus = zeta2
        End If
        If zeta3 < aus Then
            aus = zeta3
        End If
    End If
    zetaL = aus
End Function
Function zetaV(A As Double, B As Double, c As Double, d As Double) As Double
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim det As Double
    Dim aus As Double
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    pig = 3.14159265353589
    
    beta = B / A
    gamma = c / A
    delta = d / A
     
    p = gamma - (beta) ^ (2) / 3
    q = 2 * (beta) ^ (3) / 27 - beta * gamma / 3 + delta
    det = (q) ^ (2) / 4 + (p) ^ (3) / 27
   
    If det >= 0 Then
        zeta1 = -q / 2 + (det) ^ (0.5)
        zeta2 = -q / 2 - (det) ^ (0.5)
        Dim coeff1 As Integer
        Dim coeff2 As Integer
        coeff1 = 1
        coeff2 = 1
        If zeta1 < 0 Then
            zeta1 = -zeta1
            coeff1 = -1
        End If
        If zeta2 < 0 Then
            zeta2 = -zeta2
            coeff2 = -1
        End If
        u = coeff1 * (zeta1) ^ (1 / 3)
        v = coeff2 * (zeta2) ^ (1 / 3)
        y1 = u + v
        aus = y1 - beta / 3
    Else
        If q < 0 Then
            teta = Atn(-2 * (-det) ^ (0.5) / q)
        Else
            teta = pig + Atn(-2 * (-det) ^ (0.5) / q)
        End If
      
        y1 = 2 * (-p / 3) ^ (0.5) * Cos(teta / 3)
        y2 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 2 * pig) / 3)
        y3 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 4 * pig) / 3)
        zeta1 = y1 - beta / 3
        zeta2 = y2 - beta / 3
        zeta3 = y3 - beta / 3
        aus = zeta1
        If zeta2 > aus Then
            aus = zeta2
        End If
        If zeta3 > aus Then
            aus = zeta3
        End If
    End If
    zetaV = aus
End Function

Function phiRKS_L(Tc As Double, pc As Double, w As Double, T As Double, pressure As Double) As Double
    Dim R As Double
    Dim Tr As Double
    Dim S As Double
    Dim k As Double
    Dim a_min As Double
    Dim b_min As Double
    Dim A As Double
    Dim B As Double
    Dim aus As Double
    
    R = 8.3144621
    
    Tr = T / Tc
    S = 0.48 + 1.574 * w - 0.176 * (w) ^ (2)
    k = (1 + S * (1 - (Tr) ^ (0.5))) ^ (2)
    a_min = 0.42748 * (R * Tc) ^ (2) * k / pc
    b_min = 0.08664 * R * Tc / pc
    A = a_min * pressure / (R * T) ^ (2)
    B = b_min * pressure / (R * T)
    
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim aus As Double
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zetaL As Double
    pig = 3.14159265353589
    
    beta = -1
    gamma = A - B - (B) ^ (2)
    delta = -A * B
     
    p = gamma - (beta) ^ (2) / 3
    q = 2 * (beta) ^ (3) / 27 - beta * gamma / 3 + delta
    det = (q) ^ (2) / 4 + (p) ^ (3) / 27
   
    If det >= 0 Then
        zeta1 = -q / 2 + (det) ^ (0.5)
        zeta2 = -q / 2 - (det) ^ (0.5)
        Dim coeff1 As Integer
        Dim coeff2 As Integer
        coeff1 = 1
        coeff2 = 1
        If zeta1 < 0 Then
            zeta1 = -zeta1
            coeff1 = -1
        End If
        If zeta2 < 0 Then
            zeta2 = -zeta2
            coeff2 = -1
        End If
        'unterzo = 1 / 3
        u = coeff1 * (zeta1) ^ (1 / 3)
        v = coeff2 * (zeta2) ^ (1 / 3)
        y1 = u + v
        aus = y1 - beta / 3
    Else
        If q < 0 Then
            teta = Atn(-2 * (-det) ^ (0.5) / q)
        Else
            teta = pig + Atn(-2 * (-det) ^ (0.5) / q)
        End If
      
        y1 = 2 * (-p / 3) ^ (0.5) * Cos(teta / 3)
        y2 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 2 * pig) / 3)
        y3 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 4 * pig) / 3)
        zeta1 = y1 - beta / 3
        zeta2 = y2 - beta / 3
        zeta3 = y3 - beta / 3
        aus = zeta1
        If zeta2 < aus Then
            aus = zeta2
        End If
        If zeta3 < aus Then
            aus = zeta3
        End If
    End If
    zetaL = aus
    
    aus = zetaL - 1 - A * Log((zetaL + B) / zetaL) / B - Log(zetaL - B)
    phiRKS_L = Exp(aus)
End Function

Function phiRKS_V(Tc As Double, pc As Double, w As Double, T As Double, pressure As Double) As Double
    Dim R As Double
    Dim Tr As Double
    Dim S As Double
    Dim k As Double
    Dim a_min As Double
    Dim b_min As Double
    Dim A As Double
    Dim B As Double
    
    R = 8.3144621
    
    Tr = T / Tc
    S = 0.48 + 1.574 * w - 0.176 * (w) ^ (2)
    k = (1 + S * (1 - (Tr) ^ (0.5))) ^ (2)
    a_min = 0.42748 * (R * Tc) ^ (2) * k / pc
    b_min = 0.08664 * R * Tc / pc
    A = a_min * pressure / (R * T) ^ (2)
    B = b_min * pressure / (R * T)
    
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim aus As Double
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zetaV As Double
    pig = 3.14159265353589
    
    beta = -1
    gamma = A - B - (B) ^ (2)
    delta = -A * B
     
    p = gamma - (beta) ^ (2) / 3
    q = 2 * (beta) ^ (3) / 27 - beta * gamma / 3 + delta
    det = (q) ^ (2) / 4 + (p) ^ (3) / 27
   
    If det >= 0 Then
        zeta1 = -q / 2 + (det) ^ (0.5)
        zeta2 = -q / 2 - (det) ^ (0.5)
        Dim coeff1 As Integer
        Dim coeff2 As Integer
        coeff1 = 1
        coeff2 = 1
        If zeta1 < 0 Then
            zeta1 = -zeta1
            coeff1 = -1
        End If
        If zeta2 < 0 Then
            zeta2 = -zeta2
            coeff2 = -1
        End If
        'unterzo = 1 / 3
        u = coeff1 * (zeta1) ^ (1 / 3)
        v = coeff2 * (zeta2) ^ (1 / 3)
        y1 = u + v
        aus = y1 - beta / 3
    Else
        If q < 0 Then
            teta = Atn(-2 * (-det) ^ (0.5) / q)
        Else
            teta = pig + Atn(-2 * (-det) ^ (0.5) / q)
        End If
      
        y1 = 2 * (-p / 3) ^ (0.5) * Cos(teta / 3)
        y2 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 2 * pig) / 3)
        y3 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 4 * pig) / 3)
        zeta1 = y1 - beta / 3
        zeta2 = y2 - beta / 3
        zeta3 = y3 - beta / 3
        aus = zeta1
        If zeta2 > aus Then
            aus = zeta2
        End If
        If zeta3 > aus Then
            aus = zeta3
        End If
    End If
    zetaV = aus
    
    aus = zetaV - 1 - A * Log((zetaV + B) / zetaV) / B - Log(zetaV - B)
    phiRKS_V = Exp(aus)
End Function

Function phiPR_L(Tc As Double, pc As Double, w As Double, T As Double, pressure As Double) As Double
    Dim R As Double
    Dim Tr As Double
    Dim S As Double
    Dim k As Double
    Dim a_min As Double
    Dim b_min As Double
    Dim A As Double
    Dim B As Double
    Dim aus As Double
    
    R = 8.3144621
    
    Tr = T / Tc
    
    S = 0.37464 + 1.54226 * w - 0.26992 * w ^ (2)
    k = (1 + S * (1 - (Tr) ^ (0.5))) ^ (2)
    a_min = 0.45724 * (R * Tc) ^ (2) * k / pc
    b_min = 0.0778 * R * Tc / pc

    A = a_min * pressure / (R * T) ^ (2)
    B = b_min * pressure / (R * T)
    
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim aus As Double
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zetaL As Double
    pig = 3.14159265353589
    
    beta = -1 + B
    gamma = A - 2 * B - 3 * (B) ^ (2)
    delta = -A * B + (B) ^ (2) + (B) ^ (3)
     
    p = gamma - (beta) ^ (2) / 3
    q = 2 * (beta) ^ (3) / 27 - beta * gamma / 3 + delta
    det = (q) ^ (2) / 4 + (p) ^ (3) / 27
   
    If det >= 0 Then
        zeta1 = -q / 2 + (det) ^ (0.5)
        zeta2 = -q / 2 - (det) ^ (0.5)
        Dim coeff1 As Integer
        Dim coeff2 As Integer
        coeff1 = 1
        coeff2 = 1
        If zeta1 < 0 Then
            zeta1 = -zeta1
            coeff1 = -1
        End If
        If zeta2 < 0 Then
            zeta2 = -zeta2
            coeff2 = -1
        End If
        'unterzo = 1 / 3
        u = coeff1 * (zeta1) ^ (1 / 3)
        v = coeff2 * (zeta2) ^ (1 / 3)
        y1 = u + v
        aus = y1 - beta / 3
    Else
        If q < 0 Then
            teta = Atn(-2 * (-det) ^ (0.5) / q)
        Else
            teta = pig + Atn(-2 * (-det) ^ (0.5) / q)
        End If
      
        y1 = 2 * (-p / 3) ^ (0.5) * Cos(teta / 3)
        y2 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 2 * pig) / 3)
        y3 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 4 * pig) / 3)
        zeta1 = y1 - beta / 3
        zeta2 = y2 - beta / 3
        zeta3 = y3 - beta / 3
        aus = zeta1
        If zeta2 < aus Then
            aus = zeta2
        End If
        If zeta3 < aus Then
            aus = zeta3
        End If
    End If
    zetaL = aus
    
    aus = zetaL - 1 - A * Log((zetaL + B * (1 + (2) ^ (0.5))) / (zetaL + B * (1 - (2) ^ (0.5)))) / ((2) ^ (1.5) * B) - Log(zetaL - B)
    phiPR_L = Exp(aus)
End Function

Function phiPR_V(Tc As Double, pc As Double, w As Double, T As Double, pressure As Double) As Double
    Dim R As Double
    Dim Tr As Double
    Dim S As Double
    Dim k As Double
    Dim a_min As Double
    Dim b_min As Double
    Dim A As Double
    Dim B As Double
    
    R = 8.3144621
    
    Tr = T / Tc
    
    S = 0.37464 + 1.54226 * w - 0.26992 * w ^ (2)
    k = (1 + S * (1 - (Tr) ^ (0.5))) ^ (2)
    a_min = 0.45724 * (R * Tc) ^ (2) * k / pc
    b_min = 0.0778 * R * Tc / pc

    A = a_min * pressure / (R * T) ^ (2)
    B = b_min * pressure / (R * T)
    
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim aus As Double
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zetaV As Double
    pig = 3.14159265353589
    
    beta = -1 + B
    gamma = A - 2 * B - 3 * (B) ^ (2)
    delta = -A * B + (B) ^ (2) + (B) ^ (3)
     
    p = gamma - (beta) ^ (2) / 3
    q = 2 * (beta) ^ (3) / 27 - beta * gamma / 3 + delta
    det = (q) ^ (2) / 4 + (p) ^ (3) / 27
   
    If det >= 0 Then
        zeta1 = -q / 2 + (det) ^ (0.5)
        zeta2 = -q / 2 - (det) ^ (0.5)
        Dim coeff1 As Integer
        Dim coeff2 As Integer
        coeff1 = 1
        coeff2 = 1
        If zeta1 < 0 Then
            zeta1 = -zeta1
            coeff1 = -1
        End If
        If zeta2 < 0 Then
            zeta2 = -zeta2
            coeff2 = -1
        End If
        'unterzo = 1 / 3
        u = coeff1 * (zeta1) ^ (1 / 3)
        v = coeff2 * (zeta2) ^ (1 / 3)
        y1 = u + v
        aus = y1 - beta / 3
    Else
        If q < 0 Then
            teta = Atn(-2 * (-det) ^ (0.5) / q)
        Else
            teta = pig + Atn(-2 * (-det) ^ (0.5) / q)
        End If
      
        y1 = 2 * (-p / 3) ^ (0.5) * Cos(teta / 3)
        y2 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 2 * pig) / 3)
        y3 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 4 * pig) / 3)
        zeta1 = y1 - beta / 3
        zeta2 = y2 - beta / 3
        zeta3 = y3 - beta / 3
        aus = zeta1
        If zeta2 > aus Then
            aus = zeta2
        End If
        If zeta3 > aus Then
            aus = zeta3
        End If
    End If
    zetaV = aus
    
    aus = zetaV - 1 - A * Log((zetaV + B * (1 + (2) ^ (0.5))) / (zetaV + B * (1 - (2) ^ (0.5)))) / ((2) ^ (1.5) * B) - Log(zetaV - B)
    phiPR_V = Exp(aus)
End Function

Function phiRKSmix_L(indicespecie As Integer, x As Variant, NC As Integer, Tc As Variant, pc As Variant, w As Variant, T As Double, pressure As Double) As Double
    Dim amix As Double
    Dim bmix As Double
    Dim A As Double
    Dim B As Double
    Dim Ai As Double
    Dim Bi As Double
    Dim R As Double
    Dim Ac(1000) As Variant
    Dim Bc(1000) As Variant
    Dim S As Double
    Dim Tr As Double
    Dim k As Variant
    Dim i As Integer
    Dim j As Integer
    
    amix = 0
    bmix = 0
    R = 8.3144621
    For i = 1 To NC
        S = 0.48 + 1.574 * w(i) - 0.176 * (w(i)) ^ (2)
        Tr = T / Tc(i)
        k = (1 + S * (1 - (Tr) ^ (0.5))) ^ (2)
        Ac(i) = 0.42748 * (R * Tc(i)) ^ (2) * k / pc(i)
        Bc(i) = 0.08664 * R * Tc(i) / pc(i)
    Next
    For i = 1 To NC
        For j = 1 To NC
            amix = amix + x(i) * x(j) * (Ac(i) * Ac(j)) ^ (0.5)
            bmix = bmix + x(i) * x(j) * (Bc(i) + Bc(j)) / 2
        Next
    Next
    A = amix * pressure / (R * T) ^ (2)
    B = bmix * pressure / (R * T)
    Ai = Ac(indicespecie) * pressure / (R * T) ^ 2
    Bi = Bc(indicespecie) * pressure / (R * T)
 
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim aus As Variant
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zetaL As Double
    pig = 3.14159265353589
    
    beta = -1
    gamma = A - B - (B) ^ (2)
    delta = -A * B
     
    p = gamma - (beta) ^ (2) / 3
    q = 2 * (beta) ^ (3) / 27 - beta * gamma / 3 + delta
    det = (q) ^ (2) / 4 + (p) ^ (3) / 27
   
    If det >= 0 Then
        zeta1 = -q / 2 + (det) ^ (0.5)
        zeta2 = -q / 2 - (det) ^ (0.5)
        Dim coeff1 As Integer
        Dim coeff2 As Integer
        coeff1 = 1
        coeff2 = 1
        If zeta1 < 0 Then
            zeta1 = -zeta1
            coeff1 = -1
        End If
        If zeta2 < 0 Then
            zeta2 = -zeta2
            coeff2 = -1
        End If
        u = coeff1 * (zeta1) ^ (1 / 3)
        v = coeff2 * (zeta2) ^ (1 / 3)
        y1 = u + v
        aus = y1 - beta / 3
    Else
        If q < 0 Then
            teta = Atn(-2 * (-det) ^ (0.5) / q)
        Else
            teta = pig + Atn(-2 * (-det) ^ (0.5) / q)
        End If
      
        y1 = 2 * (-p / 3) ^ (0.5) * Cos(teta / 3)
        y2 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 2 * pig) / 3)
        y3 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 4 * pig) / 3)
        zeta1 = y1 - beta / 3
        zeta2 = y2 - beta / 3
        zeta3 = y3 - beta / 3
        aus = zeta1
        If zeta2 < aus Then
            aus = zeta2
        End If
        If zeta3 < aus Then
            aus = zeta3
        End If
    End If
    zetaL = aus
 
    aus = Bi * (zetaL - 1) / B + A * (Bi / B - 2 * (Ai / A) ^ (0.5)) * Log((zetaL + B) / zetaL) / B - Log(zetaL - B)
    phiRKSmix_L = Exp(aus)
End Function

Function phiRKSmix_V(indicespecie As Integer, x As Variant, NC As Integer, Tc As Variant, pc As Variant, w As Variant, T As Double, pressure As Double) As Double
    Dim amix As Double
    Dim bmix As Double
    Dim A As Double
    Dim B As Double
    Dim Ai As Double
    Dim Bi As Double
    Dim R As Double
    Dim Ac(1000) As Variant
    Dim Bc(1000) As Variant
    Dim S As Double
    Dim Tr As Double
    Dim k As Variant
    Dim i As Integer
    Dim j As Integer
    
    amix = 0
    bmix = 0
    R = 8.3144621
    For i = 1 To NC
        S = 0.48 + 1.574 * w(i) - 0.176 * (w(i)) ^ (2)
        Tr = T / Tc(i)
        k = (1 + S * (1 - (Tr) ^ (0.5))) ^ (2)
        Ac(i) = 0.42748 * (R * Tc(i)) ^ (2) * k / pc(i)
        Bc(i) = 0.08664 * R * Tc(i) / pc(i)
    Next
    For i = 1 To NC
        For j = 1 To NC
            amix = amix + x(i) * x(j) * (Ac(i) * Ac(j)) ^ (0.5)
            bmix = bmix + x(i) * x(j) * (Bc(i) + Bc(j)) / 2
        Next
    Next
    A = amix * pressure / (R * T) ^ (2)
    B = bmix * pressure / (R * T)
    Ai = Ac(indicespecie) * pressure / (R * T) ^ 2
    Bi = Bc(indicespecie) * pressure / (R * T)
 
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim aus As Variant
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zetaV As Double
    pig = 3.14159265353589
    
    beta = -1
    gamma = A - B - (B) ^ (2)
    delta = -A * B
     
    p = gamma - (beta) ^ (2) / 3
    q = 2 * (beta) ^ (3) / 27 - beta * gamma / 3 + delta
    det = (q) ^ (2) / 4 + (p) ^ (3) / 27
   
    If det >= 0 Then
        zeta1 = -q / 2 + (det) ^ (0.5)
        zeta2 = -q / 2 - (det) ^ (0.5)
        Dim coeff1 As Integer
        Dim coeff2 As Integer
        coeff1 = 1
        coeff2 = 1
        If zeta1 < 0 Then
            zeta1 = -zeta1
            coeff1 = -1
        End If
        If zeta2 < 0 Then
            zeta2 = -zeta2
            coeff2 = -1
        End If
        u = coeff1 * (zeta1) ^ (1 / 3)
        v = coeff2 * (zeta2) ^ (1 / 3)
        y1 = u + v
        aus = y1 - beta / 3
    Else
        If q < 0 Then
            teta = Atn(-2 * (-det) ^ (0.5) / q)
        Else
            teta = pig + Atn(-2 * (-det) ^ (0.5) / q)
        End If
      
        y1 = 2 * (-p / 3) ^ (0.5) * Cos(teta / 3)
        y2 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 2 * pig) / 3)
        y3 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 4 * pig) / 3)
        zeta1 = y1 - beta / 3
        zeta2 = y2 - beta / 3
        zeta3 = y3 - beta / 3
        aus = zeta1
        If zeta2 > aus Then
            aus = zeta2
        End If
        If zeta3 > aus Then
            aus = zeta3
        End If
    End If
    zetaV = aus
 
    aus = Bi * (zetaV - 1) / B + A * (Bi / B - 2 * (Ai / A) ^ (0.5)) * Log((zetaV + B) / zetaV) / B - Log(zetaV - B)
    phiRKSmix_V = Exp(aus)
End Function
Function phiPRmix_L(indicespecie As Integer, x As Variant, NC As Integer, Tc As Variant, pc As Variant, w As Variant, T As Double, pressure As Double) As Double
    Dim amix As Double
    Dim bmix As Double
    Dim A As Double
    Dim B As Double
    Dim Ai As Double
    Dim Bi As Double
    Dim R As Double
    Dim Ac(1000) As Variant
    Dim Bc(1000) As Variant
    Dim S As Double
    Dim Tr As Double
    Dim k As Variant
    Dim i As Integer
    Dim j As Integer
    
    amix = 0
    bmix = 0
    R = 8.3144621
    For i = 1 To NC
        S = 0.37464 + 1.54226 * w(i) - 0.26992 * (w(i)) ^ (2)
        Tr = T / Tc(i)
        k = (1 + S * (1 - (Tr) ^ (0.5))) ^ (2)
        Ac(i) = 0.45724 * (R * Tc(i)) ^ (2) * k / pc(i)
        Bc(i) = 0.0778 * R * Tc(i) / pc(i)
    Next
    For i = 1 To NC
        For j = 1 To NC
            amix = amix + x(i) * x(j) * (Ac(i) * Ac(j)) ^ (0.5)
            bmix = bmix + x(i) * x(j) * (Bc(i) + Bc(j)) / 2
        Next
    Next
    A = amix * pressure / (R * T) ^ (2)
    B = bmix * pressure / (R * T)
    Ai = Ac(indicespecie) * pressure / (R * T) ^ 2
    Bi = Bc(indicespecie) * pressure / (R * T)
 
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim aus As Variant
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zetaL As Double
    pig = 3.14159265353589
    
    beta = -1 + B
    gamma = A - 2 * B - 3 * (B) ^ (2)
    delta = -A * B + (B) ^ (2) + B^(3)
     
    p = gamma - (beta) ^ (2) / 3
    q = 2 * (beta) ^ (3) / 27 - beta * gamma / 3 + delta
    det = (q) ^ (2) / 4 + (p) ^ (3) / 27
   
    If det >= 0 Then
        zeta1 = -q / 2 + (det) ^ (0.5)
        zeta2 = -q / 2 - (det) ^ (0.5)
        Dim coeff1 As Integer
        Dim coeff2 As Integer
        coeff1 = 1
        coeff2 = 1
        If zeta1 < 0 Then
            zeta1 = -zeta1
            coeff1 = -1
        End If
        If zeta2 < 0 Then
            zeta2 = -zeta2
            coeff2 = -1
        End If
        u = coeff1 * (zeta1) ^ (1 / 3)
        v = coeff2 * (zeta2) ^ (1 / 3)
        y1 = u + v
        aus = y1 - beta / 3
    Else
        If q < 0 Then
            teta = Atn(-2 * (-det) ^ (0.5) / q)
        Else
            teta = pig + Atn(-2 * (-det) ^ (0.5) / q)
        End If
      
        y1 = 2 * (-p / 3) ^ (0.5) * Cos(teta / 3)
        y2 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 2 * pig) / 3)
        y3 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 4 * pig) / 3)
        zeta1 = y1 - beta / 3
        zeta2 = y2 - beta / 3
        zeta3 = y3 - beta / 3
        aus = zeta1
        If zeta2 < aus Then
            aus = zeta2
        End If
        If zeta3 < aus Then
            aus = zeta3
        End If
    End If
    zetaL = aus
 
    aus = Bi * (zetaL - 1) / B + A * (Bi / B - 2 * (Ai / A) ^ (0.5)) * Log((zetaL + B * (1 + (2) ^ (0.5))) / (zetaL + B * (1 - (2) ^ (0.5)))) / ((2) ^ (1.5) * B) - Log(zetaL - B)
    phiPRmix_L = Exp(aus)
End Function

Function phiPRmix_V(indicespecie As Integer, x As Variant, NC As Integer, Tc As Variant, pc As Variant, w As Variant, T As Double, pressure As Double) As Double
    Dim amix As Double
    Dim bmix As Double
    Dim A As Double
    Dim B As Double
    Dim Ai As Double
    Dim Bi As Double
    Dim R As Double
    Dim Ac(1000) As Variant
    Dim Bc(1000) As Variant
    Dim S As Double
    Dim Tr As Double
    Dim k As Variant
    Dim i As Integer
    Dim j As Integer
    
    amix = 0
    bmix = 0
    R = 8.3144621
    For i = 1 To NC
        S = 0.37464 + 1.54226 * w(i) - 0.26992 * (w(i)) ^ (2)
        Tr = T / Tc(i)
        k = (1 + S * (1 - (Tr) ^ (0.5))) ^ (2)
        Ac(i) = 0.45724 * (R * Tc(i)) ^ (2) * k / pc(i)
        Bc(i) = 0.0778 * R * Tc(i) / pc(i)
    Next
    For i = 1 To NC
        For j = 1 To NC
            amix = amix + x(i) * x(j) * (Ac(i) * Ac(j)) ^ (0.5)
            bmix = bmix + x(i) * x(j) * (Bc(i) + Bc(j)) / 2
        Next
    Next
    A = amix * pressure / (R * T) ^ (2)
    B = bmix * pressure / (R * T)
    Ai = Ac(indicespecie) * pressure / (R * T) ^ 2
    Bi = Bc(indicespecie) * pressure / (R * T)
 
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim aus As Variant
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zetaV As Double
    pig = 3.14159265353589
    
    beta = -1 + B
    gamma = A - 2 * B - 3 * (B) ^ (2)
    delta = -A * B + (B) ^ (2) + (B) ^ (3)
     
    p = gamma - (beta) ^ (2) / 3
    q = 2 * (beta) ^ (3) / 27 - beta * gamma / 3 + delta
    det = (q) ^ (2) / 4 + (p) ^ (3) / 27
   
    If det >= 0 Then
        zeta1 = -q / 2 + (det) ^ (0.5)
        zeta2 = -q / 2 - (det) ^ (0.5)
        Dim coeff1 As Integer
        Dim coeff2 As Integer
        coeff1 = 1
        coeff2 = 1
        If zeta1 < 0 Then
            zeta1 = -zeta1
            coeff1 = -1
        End If
        If zeta2 < 0 Then
            zeta2 = -zeta2
            coeff2 = -1
        End If
        u = coeff1 * (zeta1) ^ (1 / 3)
        v = coeff2 * (zeta2) ^ (1 / 3)
        y1 = u + v
        aus = y1 - beta / 3
    Else
        If q < 0 Then
            teta = Atn(-2 * (-det) ^ (0.5) / q)
        Else
            teta = pig + Atn(-2 * (-det) ^ (0.5) / q)
        End If
      
        y1 = 2 * (-p / 3) ^ (0.5) * Cos(teta / 3)
        y2 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 2 * pig) / 3)
        y3 = 2 * (-p / 3) ^ (0.5) * Cos((teta + 4 * pig) / 3)
        zeta1 = y1 - beta / 3
        zeta2 = y2 - beta / 3
        zeta3 = y3 - beta / 3
        aus = zeta1
        If zeta2 > aus Then
            aus = zeta2
        End If
        If zeta3 > aus Then
            aus = zeta3
        End If
    End If
    zetaV = aus
 
    aus = Bi * (zetaV - 1) / B + A * (Bi / B - 2 * (Ai / A) ^ (0.5)) * Log((zetaV + B * (1 + (2) ^ (0.5))) / (zetaV + B * (1 - (2) ^ (0.5)))) / ((2) ^ (1.5) * B) - Log(zetaV - B)
    phiPRmix_V = Exp(aus)
End Function


