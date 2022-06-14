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





Function zeta_VdW(Tc As Double, pc As Double, T As Double, pressure As Double, state As String) As Double
    Dim R As Double
    Dim Tr As Double
    Dim a_min As Double
    Dim b_min As Double
    Dim a As Double
    Dim b As Double
    Dim aus As Double
    
    R = 8.3144621
    
    Tr = T / Tc
    a_min = 0.421875 * (R * Tc) ^ (2) / pc
    b_min = 0.125 * R * Tc / pc
    a = a_min * pressure / (R * T) ^ (2)
    b = b_min * pressure / (R * T)
    
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zeta As Double
    pig = 3.14159265353589
    
    beta = - 1 - b
    gamma = a
    delta = -a * b
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta_VdW = aus
End Function


Function zeta_RK(Tc As Double, pc As Double, T As Double, pressure As Double, state As String) As Double
    Dim R As Double
    Dim Tr As Double
    Dim k As Double
    Dim a_min As Double
    Dim b_min As Double
    Dim a As Double
    Dim b As Double
    Dim aus As Double
    
    R = 8.3144621
    
    Tr = T / Tc
    k = 1/(Tr) ^ (0.5)
    a_min = 0.42748 * (R * Tc) ^ (2) * k / pc
    b_min = 0.08664 * R * Tc / pc
    a = a_min * pressure / (R * T) ^ (2)
    b = b_min * pressure / (R * T)
    
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zeta As Double
    pig = 3.14159265353589
    
    beta = - 1
    gamma = a - b - (b) ^ (2)
    delta = - a * b
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta_RK = aus
End Function


Function zeta_RKS(Tc As Double, pc As Double, w As Double, T As Double, pressure As Double, state As String) As Double
    Dim R As Double
    Dim Tr As Double
    Dim S As Double
    Dim k As Double
    Dim a_min As Double
    Dim b_min As Double
    Dim a As Double
    Dim b As Double
    Dim aus As Double
    
    R = 8.3144621
    
    Tr = T / Tc
    S = 0.48 + 1.574 * w - 0.176 * (w) ^ (2)
    k = (1 + S * (1 - (Tr) ^ (0.5))) ^ (2)
    a_min = 0.42748 * (R * Tc) ^ (2) * k / pc
    b_min = 0.08664 * R * Tc / pc
    a = a_min * pressure / (R * T) ^ (2)
    b = b_min * pressure / (R * T)
    
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zeta As Double
    pig = 3.14159265353589
    
    beta = - 1
    gamma = a - b - (b) ^ (2)
    delta = - a * b
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta_RKS = aus
End Function


Function zeta_PR(Tc As Double, pc As Double, w As Double, T As Double, pressure As Double, state As String) As Double
    Dim R As Double
    Dim Tr As Double
    Dim S As Double
    Dim k As Double
    Dim a_min As Double
    Dim b_min As Double
    Dim a As Double
    Dim b As Double
    Dim aus As Double
    
    R = 8.3144621
    
    Tr = T / Tc
    
    S = 0.37464 + 1.54226 * w - 0.26992 * w ^ (2)
    k = (1 + S * (1 - (Tr) ^ (0.5))) ^ (2)
    a_min = 0.45724 * (R * Tc) ^ (2) * k / pc
    b_min = 0.0778 * R * Tc / pc

    a = a_min * pressure / (R * T) ^ (2)
    b = b_min * pressure / (R * T)
    
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zeta As Double
    pig = 3.14159265353589
    
    beta = - 1 + b
    gamma = a - 2 * b - 3 * (b) ^ (2)
    delta = -a * b + (b) ^ (2) + (b) ^ (3)
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta_PR = aus
End Function


Function phi_VdW(Tc As Double, pc As Double, T As Double, pressure As Double, state As String) As Double
    Dim R As Double
    Dim Tr As Double
    Dim a_min As Double
    Dim b_min As Double
    Dim a As Double
    Dim b As Double
    Dim aus As Double
    
    R = 8.3144621
    
    Tr = T / Tc
    a_min = 0.421875 * (R * Tc) ^ (2) / pc
    b_min = 0.125 * R * Tc / pc
    a = a_min * pressure / (R * T) ^ (2)
    b = b_min * pressure / (R * T)
    
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zeta As Double
    pig = 3.14159265353589
    
    beta = - 1 - b
    gamma = a
    delta = - a * b
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta = aus
    
    aus = zeta - 1 - a / zeta - Log( zeta - b )
    phi_VdW = Exp(aus)
End Function


Function phi_RK(Tc As Double, pc As Double, T As Double, pressure As Double, state As String) As Double
    Dim R As Double
    Dim Tr As Double
    Dim k As Double
    Dim a_min As Double
    Dim b_min As Double
    Dim a As Double
    Dim b As Double
    Dim aus As Double
    
    R = 8.3144621
    
    Tr = T / Tc
    k = 1/(Tr) ^ (0.5)
    a_min = 0.42748 * (R * Tc) ^ (2) * k / pc
    b_min = 0.08664 * R * Tc / pc
    a = a_min * pressure / (R * T) ^ (2)
    b = b_min * pressure / (R * T)
    
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zeta As Double
    pig = 3.14159265353589
    
    beta = - 1
    gamma = a - b - (b) ^ (2)
    delta = - a * b
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta = aus
    
    aus = zeta - 1 - a * Log((zeta + b) / zeta) / b - Log(zeta - b)
    phi_RK = Exp(aus)
End Function


Function phi_RKS(Tc As Double, pc As Double, w As Double, T As Double, pressure As Double, state As String) As Double
    Dim R As Double
    Dim Tr As Double
    Dim S As Double
    Dim k As Double
    Dim a_min As Double
    Dim b_min As Double
    Dim a As Double
    Dim b As Double
    Dim aus As Double
    
    R = 8.3144621
    
    Tr = T / Tc
    S = 0.48 + 1.574 * w - 0.176 * (w) ^ (2)
    k = (1 + S * (1 - (Tr) ^ (0.5))) ^ (2)
    a_min = 0.42748 * (R * Tc) ^ (2) * k / pc
    b_min = 0.08664 * R * Tc / pc
    a = a_min * pressure / (R * T) ^ (2)
    b = b_min * pressure / (R * T)
    
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zeta As Double
    pig = 3.14159265353589
    
    beta = - 1
    gamma = a - b - (b) ^ (2)
    delta = - a * b
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta = aus
    
    aus = zeta - 1 - a * Log((zeta + b) / zeta) / b - Log(zeta - b)
    phi_RKS = Exp(aus)
End Function


Function phi_PR(Tc As Double, pc As Double, w As Double, T As Double, pressure As Double, state As String) As Double
    Dim R As Double
    Dim Tr As Double
    Dim S As Double
    Dim k As Double
    Dim a_min As Double
    Dim b_min As Double
    Dim a As Double
    Dim b As Double
    Dim aus As Double
    
    R = 8.3144621
    
    Tr = T / Tc
    
    S = 0.37464 + 1.54226 * w - 0.26992 * w ^ (2)
    k = (1 + S * (1 - (Tr) ^ (0.5))) ^ (2)
    a_min = 0.45724 * (R * Tc) ^ (2) * k / pc
    b_min = 0.0778 * R * Tc / pc

    a = a_min * pressure / (R * T) ^ (2)
    b = b_min * pressure / (R * T)
    
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zeta As Double
    pig = 3.14159265353589
    
    beta = - 1 + b
    gamma = a - 2 * b - 3 * (b) ^ (2)
    delta = -a * b + (b) ^ (2) + (b) ^ (3)
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta = aus
    
    aus = zeta - 1 - a * Log((zeta + b) / zeta) / b - Log(zeta - b)
    phi_PR = Exp(aus)
End Function


Function hR_VdW(Tc As Double, pc As Double, T As Double, pressure As Double, state As String) As Double
    Dim R As Double
    Dim Tr As Double
    Dim a_min As Double
    Dim b_min As Double
    Dim a As Double
    Dim b As Double
    Dim aus As Double
    
    R = 8.3144621
    
    Tr = T / Tc
    a_min = 0.421875 * (R * Tc) ^ (2) / pc
    b_min = 0.125 * R * Tc / pc
    a = a_min * pressure / (R * T) ^ (2)
    b = b_min * pressure / (R * T)
    
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zeta As Double
    pig = 3.14159265353589
    
    beta = - 1 - b
    gamma = a
    delta = - a * b
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta = aus
    
    hR_VdW = zeta - 1 - a / zeta
	hR_VdW = hR_VdW * R * T
End Function


Function hR_RK(Tc As Double, pc As Double, T As Double, pressure As Double, state As String) As Double
    Dim R As Double
    Dim Tr As Double
    Dim k As Double
    Dim a_min As Double
    Dim b_min As Double
    Dim a As Double
    Dim b As Double
    Dim aus As Double
    
    R = 8.3144621
    
    Tr = T / Tc
    k = 1/(Tr) ^ (0.5)
    a_min = 0.42748 * (R * Tc) ^ (2) * k / pc
    b_min = 0.08664 * R * Tc / pc
    a = a_min * pressure / (R * T) ^ (2)
    b = b_min * pressure / (R * T)
    
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zeta As Double
    pig = 3.14159265353589
    
    beta = - 1
    gamma = a - b - (b) ^ (2)
    delta = - a * b
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta = aus
    
    hR_RK = zeta - 1 - 1.5 * a / b * log((zeta + b)/zeta)
	hR_RK = hR_RK * R * T
End Function


Function hR_RKS(Tc As Double, pc As Double, w As Double, T As Double, pressure As Double, state As String) As Double
    Dim R As Double
    Dim Tr As Double
    Dim S As Double
    Dim k As Double
    Dim a_min As Double
    Dim b_min As Double
    Dim a As Double
    Dim b As Double
    Dim aus As Double
    
    R = 8.3144621
    
    Tr = T / Tc
    S = 0.48 + 1.574 * w - 0.176 * (w) ^ (2)
    k = (1 + S * (1 - (Tr) ^ (0.5))) ^ (2)
    a_min = 0.42748 * (R * Tc) ^ (2) * k / pc
    b_min = 0.08664 * R * Tc / pc
    a = a_min * pressure / (R * T) ^ (2)
    b = b_min * pressure / (R * T)
    
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zeta As Double
    pig = 3.14159265353589
    
    beta = - 1
    gamma = a - b - (b) ^ (2)
    delta = - a * b
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta = aus
    E = S * (Tr / k)^(0.5)
    hR_RKS = zeta - 1 - ( 1 + E ) * A / B * log((zeta + b)/zeta)
	hR_RKS = hR_RKS * R * T
End Function


Function hR_PR(Tc As Double, pc As Double, w As Double, T As Double, pressure As Double, state As String) As Double
    Dim R As Double
    Dim Tr As Double
    Dim S As Double
    Dim k As Double
    Dim a_min As Double
    Dim b_min As Double
    Dim a As Double
    Dim b As Double
    Dim aus As Double
    
    R = 8.3144621
    
    Tr = T / Tc
    
    S = 0.37464 + 1.54226 * w - 0.26992 * w ^ (2)
    k = (1 + S * (1 - (Tr) ^ (0.5))) ^ (2)
    a_min = 0.45724 * (R * Tc) ^ (2) * k / pc
    b_min = 0.0778 * R * Tc / pc

    a = a_min * pressure / (R * T) ^ (2)
    b = b_min * pressure / (R * T)
    
    Dim p As Double
    Dim q As Double
    Dim u As Double
    Dim v As Double
    Dim y1 As Double
    Dim y2 As Double
    Dim y3 As Double
    Dim det As Double
    Dim teta As Double
    Dim zeta1 As Double
    Dim zeta2 As Double
    Dim zeta3 As Double
    Dim beta As Double
    Dim gamma As Double
    Dim delta As Double
    Dim pig As Double
    Dim zeta As Double
    pig = 3.14159265353589
    
    beta = - 1 + b
    gamma = a - 2 * b - 3 * (b) ^ (2)
    delta = - a * b + (b) ^ (2) + (b) ^ (3)
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta = aus
    
	E = S * (Tr / k)^(0.5)
    hR_PR = zeta - 1 - ( 1 + E ) * A / B / (2)^(1.5) * log((zeta + b * (1 + (2)^(0.5)))/(zeta + b * (1 - (2)^(0.5))))
	hR_PR = hR_PR * R * T
End Function


Function phi_VdWmix(indicespecie As Integer, x As Variant, NC As Integer, Tc As Variant, pc As Variant, w As Variant, T As Double, pressure As Double, state As string) As Double
    Dim amix As Double
    Dim bmix As Double
    Dim a As Double
    Dim b As Double
    Dim Ai As Double
    Dim Bi As Double
    Dim R As Double
    Dim Ac(1000) As Variant
    Dim Bc(1000) As Variant
    Dim Tr As Double
    Dim k As Variant
    Dim i As Integer
    Dim j As Integer
    
    amix = 0
    bmix = 0
    R = 8.3144621
    For i = 1 To NC
        Tr = T / Tc(i)
        Ac(i) = 0.421875 * (R * Tc(i)) ^ (2) / pc(i)
        Bc(i) = 0.125 * R * Tc(i) / pc(i)
    Next
    For i = 1 To NC
        For j = 1 To NC
            amix = amix + x(i) * x(j) * (Ac(i) * Ac(j)) ^ (0.5)
            bmix = bmix + x(i) * x(j) * (Bc(i) + Bc(j)) / 2
        Next
    Next
    a = amix * pressure / (R * T) ^ (2)
    b = bmix * pressure / (R * T)
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
    Dim zeta As Double
    pig = 3.14159265353589
	
	beta = - 1 - b
    gamma = a
    delta = -a * b
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta = aus
	
	aus = Bi/(zeta-B)-2*(Ai*A)^(0.5)/zeta-log(zeta-B) 
    
    phi_VdWmix = Exp(aus)
End Function


Function phi_RKmix(indicespecie As Integer, x As Variant, NC As Integer, Tc As Variant, pc As Variant, w As Variant, T As Double, pressure As Double, state As string) As Double
    Dim amix As Double
    Dim bmix As Double
    Dim a As Double
    Dim b As Double
    Dim Ai As Double
    Dim Bi As Double
    Dim R As Double
    Dim Ac(1000) As Variant
    Dim Bc(1000) As Variant
    Dim Tr As Double
    Dim k As Variant
    Dim i As Integer
    Dim j As Integer
    
    amix = 0
    bmix = 0
    R = 8.3144621
    For i = 1 To NC
        Tr = T / Tc(i)
        k = 1 / (Tr)^(0.5)
        Ac(i) = 0.42748 * (R * Tc(i)) ^ (2) * k / pc(i)
        Bc(i) = 0.08664 * R * Tc(i) / pc(i)
    Next
    For i = 1 To NC
        For j = 1 To NC
            amix = amix + x(i) * x(j) * (Ac(i) * Ac(j)) ^ (0.5)
            bmix = bmix + x(i) * x(j) * (Bc(i) + Bc(j)) / 2
        Next
    Next
    a = amix * pressure / (R * T) ^ (2)
    b = bmix * pressure / (R * T)
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
    Dim zeta As Double
    pig = 3.14159265353589
    
    beta = -1
    gamma = a - b - (b) ^ (2)
    delta = -a * b
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta = aus
 
    aus = Bi * (zeta - 1) / b + a * (Bi / b - 2 * (Ai / a) ^ (0.5)) * Log((zeta + b) / zeta) / b - Log(zeta - b)
    phi_RKmix = Exp(aus)
End Function


Function phi_RKSmix(indicespecie As Integer, x As Variant, NC As Integer, Tc As Variant, pc As Variant, w As Variant, T As Double, pressure As Double, state As string) As Double
    Dim amix As Double
    Dim bmix As Double
    Dim a As Double
    Dim b As Double
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
    a = amix * pressure / (R * T) ^ (2)
    b = bmix * pressure / (R * T)
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
    Dim zeta As Double
    pig = 3.14159265353589
    
    beta = -1
    gamma = a - b - (b) ^ (2)
    delta = -a * b
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta = aus
 
    aus = Bi * (zeta - 1) / b + a * (Bi / b - 2 * (Ai / a) ^ (0.5)) * Log((zeta + b) / zeta) / b - Log(zeta - b)
    phi_RKSmix = Exp(aus)
End Function


Function phi_PRmix(indicespecie As Integer, x As Variant, NC As Integer, Tc As Variant, pc As Variant, w As Variant, T As Double, pressure As Double, state As string) As Double
    Dim amix As Double
    Dim bmix As Double
    Dim a As Double
    Dim b As Double
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
    a = amix * pressure / (R * T) ^ (2)
    b = bmix * pressure / (R * T)
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
    Dim zeta As Double
    pig = 3.14159265353589
    
    beta = - 1 + b
    gamma = a - 2*b - 3*(b) ^ (2)
    delta = -a * b + (b)^(2) + (b)^(3)
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta = aus
	aus = Bi * (zeta - 1) / B + A * (Bi / B - 2 * (Ai / A) ^ (0.5)) * Log((zeta + B * (1 + (2) ^ (0.5))) / (zeta + B * (1 - (2) ^ (0.5)))) / ((2) ^ (1.5) * B) - Log(zeta - B)

    phi_PRmix = Exp(aus)
End Function


Function hR_VdWmix(x As Variant, NC As Integer, Tc As Variant, pc As Variant, w As Variant, T As Double, pressure As Double, state As string) As Double
    Dim amix As Double
    Dim bmix As Double
    Dim a As Double
    Dim b As Double
    Dim R As Double
    Dim Ac(1000) As Variant
    Dim Bc(1000) As Variant
    Dim Tr As Double
    Dim k As Variant
    Dim i As Integer
    Dim j As Integer
    
    amix = 0
    bmix = 0
    R = 8.3144621
    For i = 1 To NC
        Tr = T / Tc(i)
        Ac(i) = 0.421875 * (R * Tc(i)) ^ (2) / pc(i)
        Bc(i) = 0.125 * R * Tc(i) / pc(i)
    Next
    For i = 1 To NC
        For j = 1 To NC
            amix = amix + x(i) * x(j) * (Ac(i) * Ac(j)) ^ (0.5)
            bmix = bmix + x(i) * x(j) * (Bc(i) + Bc(j)) / 2
        Next
    Next
    a = amix * pressure / (R * T) ^ (2)
    b = bmix * pressure / (R * T)
     
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
    Dim zeta As Double
    pig = 3.14159265353589
	
	beta = - 1 - b
    gamma = a
    delta = -a * b
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta = aus 
	
    hR_VdWmix = zeta - 1 - a / zeta
	hR_VdWmix = hR_VdWmix * R * T
End Function


Function hR_RKmix(x As Variant, NC As Integer, Tc As Variant, pc As Variant, w As Variant, T As Double, pressure As Double, state As string) As Double
    Dim amix As Double
    Dim bmix As Double
    Dim a As Double
    Dim b As Double
    Dim R As Double
    Dim Ac(1000) As Variant
    Dim Bc(1000) As Variant
    Dim Tr As Double
    Dim k As Variant
    Dim i As Integer
    Dim j As Integer
    
    amix = 0
    bmix = 0
    R = 8.3144621
    For i = 1 To NC
        Tr = T / Tc(i)
        k = 1 / (Tr)^(0.5)
        Ac(i) = 0.42748 * (R * Tc(i)) ^ (2) * k / pc(i)
        Bc(i) = 0.08664 * R * Tc(i) / pc(i)
    Next
    For i = 1 To NC
        For j = 1 To NC
            amix = amix + x(i) * x(j) * (Ac(i) * Ac(j)) ^ (0.5)
            bmix = bmix + x(i) * x(j) * (Bc(i) + Bc(j)) / 2
        Next
    Next
    a = amix * pressure / (R * T) ^ (2)
    b = bmix * pressure / (R * T)
    
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
    Dim zeta As Double
    pig = 3.14159265353589
    
    beta = -1
    gamma = a - b - (b) ^ (2)
    delta = -a * b
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta = aus
 
    hR_RKmix = zeta - 1 - 1.5 * a / b * log((zeta + b)/zeta)
	hR_RKmix = hR_RKmix * R * T
End Function


Function hR_RKSmix(x As Variant, NC As Integer, Tc As Variant, pc As Variant, w As Variant, T As Double, pressure As Double, state As string) As Double
    Dim amix As Double
    Dim bmix As Double
    Dim a As Double
    Dim b As Double
    Dim R As Double
    Dim Ac(1000) As Variant
    Dim Bc(1000) As Variant
    Dim S(1000) As Variant
    Dim Tr(1000) As Variant
    Dim k(1000) As Variant
    Dim i As Integer
    Dim j As Integer
    
    amix = 0
    bmix = 0
    R = 8.3144621
    For i = 1 To NC
        S(i) = 0.48 + 1.574 * w(i) - 0.176 * (w(i)) ^ (2)
        Tr(i) = T / Tc(i)
        k(i) = (1 + S(i) * (1 - (Tr(i)) ^ (0.5))) ^ (2)
        Ac(i) = 0.42748 * (R * Tc(i)) ^ (2) * k(i) / pc(i)
        Bc(i) = 0.08664 * R * Tc(i) / pc(i)
    Next
    For i = 1 To NC
        For j = 1 To NC
            amix = amix + x(i) * x(j) * (Ac(i) * Ac(j)) ^ (0.5)
            bmix = bmix + x(i) * x(j) * (Bc(i) + Bc(j)) / 2
        Next
    Next
    a = amix * pressure / (R * T) ^ (2)
    b = bmix * pressure / (R * T)
 
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
    Dim zeta As Double
	Dim E As Double
	
    pig = 3.14159265353589
    
    beta = -1
    gamma = a - b - (b) ^ (2)
    delta = -a * b
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta = aus
	
	E = 0
	for i = 1 to NC
		E = E + x(i) * S(i) * (ac(i) * Tr(i) / k(i))^(0.5)
	Next
	E = E / (amix)^(0.5)
    hR_RKSmix = zeta - 1 - ( 1 + E ) * A / B * log((zeta + b)/zeta)
	hR_RKSmix = hR_RKSmix * R * T
End Function


Function hR_PRmix(x As Variant, NC As Integer, Tc As Variant, pc As Variant, w As Variant, T As Double, pressure As Double, state As string) As Double
    Dim amix As Double
    Dim bmix As Double
    Dim a As Double
    Dim b As Double
    Dim R As Double
    Dim Ac(1000) As Variant
    Dim Bc(1000) As Variant
    Dim S(1000) As Variant
    Dim Tr(1000) As Variant
    Dim k(1000) As Variant
    Dim i As Integer
    Dim j As Integer
    
    amix = 0
    bmix = 0
    R = 8.3144621
    For i = 1 To NC
        S(i) = 0.37464 + 1.54226 * w(i) - 0.26992 * (w(i)) ^ (2)
        Tr(i) = T / Tc(i)
        k(i) = (1 + S(i) * (1 - (Tr(i)) ^ (0.5))) ^ (2)
        Ac(i) = 0.45724 * (R * Tc(i)) ^ (2) * k(i) / pc(i)
        Bc(i) = 0.0778 * R * Tc(i) / pc(i)
    Next
    For i = 1 To NC
        For j = 1 To NC
            amix = amix + x(i) * x(j) * (Ac(i) * Ac(j)) ^ (0.5)
            bmix = bmix + x(i) * x(j) * (Bc(i) + Bc(j)) / 2
        Next
    Next
    a = amix * pressure / (R * T) ^ (2)
    b = bmix * pressure / (R * T)
 
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
    Dim zeta As Double
	Dim E As Double
    pig = 3.14159265353589
    
    beta = - 1 + b
    gamma = a - 2*b - 3*(b) ^ (2)
    delta = -a * b + (b)^(2) + (b)^(3)
     
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
        If state = "L" Then
            'LIQUID PHASE
            If zeta2 < aus Then
                aus = zeta2
            End If
            If zeta3 < aus Then
                aus = zeta3
            End If
        ElseIf state = "V" Then
            'VAPOUR PHASE
            If zeta2 > aus Then
            aus = zeta2
            End If
            If zeta3 > aus Then
                aus = zeta3
            End If
        End If
    End If
    zeta = aus
	
	E = 0
	for i = 1 to NC
		E = E + x(i) * S(i) * (Ac(i) * Tr(i) / k(i))^(0.5)
	Next
	E = E / (amix)^(0.5)

    hR_PRmix = zeta - 1 - ( 1 + E ) * A / B / (2)^(1.5) * log((zeta + b * (1 + (2)^(0.5)))/(zeta + b * (1 - (2)^(0.5))))
	hR_PRmix = hR_PRmix * R * T
End Function