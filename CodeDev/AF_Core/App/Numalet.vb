Imports System
Imports System.Text
Imports System.Globalization

''' <summary>
''' Convierte números en su expresión numérica a su numeral cardinal
''' </summary>
Public NotInheritable Class Numalet

#Region "Miembros estáticos"

  Private Const UNI As Integer = 0, DIECI As Integer = 1, DECENA As Integer = 2, CENTENA As Integer = 3
  Private Shared _matriz As String(,) = New String(CENTENA, 9) {
      {Nothing, " uno", " dos", " tres", " cuatro", " cinco", " seis", " siete", " ocho", " nueve"},
      {" diez", " once", " doce", " trece", " catorce", " quince", " dieciséis", " diecisiete", " dieciocho", " diecinueve"},
      {Nothing, Nothing, Nothing, " treinta", " cuarenta", " cincuenta", " sesenta", " setenta", " ochenta", " noventa"},
      {Nothing, Nothing, Nothing, Nothing, Nothing, " quinientos", Nothing, " setecientos", Nothing, " novecientos"}}
  Private Const [sub] As Char = CChar(ChrW(26))
  'Cambiar acá si se quiere otro comportamiento en los métodos de clase
  Public Const SeparadorDecimalSalidaDefault As String = "con"
  Public Const MascaraSalidaDecimalDefault As String = "00'/100.-'"
  Public Const DecimalesDefault As Int32 = 2
  Public Const LetraCapitalDefault As Boolean = False
  Public Const ConvertirDecimalesDefault As Boolean = False
  Public Const ApocoparUnoParteEnteraDefault As Boolean = False
  Public Const ApocoparUnoParteDecimalDefault As Boolean = False

#End Region

#Region "Propiedades"

  Private _decimales As Int32 = DecimalesDefault
  Private _cultureInfo As CultureInfo = Globalization.CultureInfo.CurrentCulture
  Private _separadorDecimalSalida As String = SeparadorDecimalSalidaDefault
  Private _posiciones As Int32 = DecimalesDefault
  Private _mascaraSalidaDecimal As String, _mascaraSalidaDecimalInterna As String = MascaraSalidaDecimalDefault
  Private _esMascaraNumerica As Boolean = True
  Private _letraCapital As Boolean = LetraCapitalDefault
  Private _convertirDecimales As Boolean = ConvertirDecimalesDefault
  Private _apocoparUnoParteEntera As Boolean = False
  Private _apocoparUnoParteDecimal As Boolean

  ''' <summary>
  ''' Indica la cantidad de decimales que se pasarán a entero para la conversión
  ''' </summary>
  ''' <remarks>Esta propiedad cambia al cambiar MascaraDecimal por un valor que empieze con '0'</remarks>
  Public Property Decimales() As Int32
    Get
      Return _decimales
    End Get
    Set(ByVal value As Int32)
      If value > 10 Then
        Throw New ArgumentException(value.ToString() + " excede el número máximo de decimales admitidos, solo se admiten hasta 10.")
      End If
      _decimales = value
    End Set
  End Property

  ''' <summary>
  ''' Objeto CultureInfo utilizado para convertir las cadenas de entrada en números
  ''' </summary>
  Public Property CultureInfo() As CultureInfo
    Get
      Return _cultureInfo
    End Get
    Set(ByVal value As CultureInfo)
      _cultureInfo = value
    End Set
  End Property

  ''' <summary>
  ''' Indica la cadena a intercalar entre la parte entera y la decimal del número
  ''' </summary>
  Public Property SeparadorDecimalSalida() As String
    Get
      Return _separadorDecimalSalida
    End Get
    Set(ByVal value As String)
      _separadorDecimalSalida = value
      'Si el separador decimal es compuesto, infiero que estoy cuantificando algo,
      'por lo que apocopo el "uno" convirtiéndolo en "un"
      If value.Trim().IndexOf(" ") > 0 Then
        _apocoparUnoParteEntera = True
      Else
        _apocoparUnoParteEntera = False
      End If
    End Set
  End Property

  ''' <summary>
  ''' Indica el formato que se le dara a la parte decimal del número
  ''' </summary>
  Public Property MascaraSalidaDecimal() As String
    Get
      If Not [String].IsNullOrEmpty(_mascaraSalidaDecimal) Then
        Return _mascaraSalidaDecimal
      Else
        Return ""
      End If
    End Get
    Set(ByVal value As String)
      'determino la cantidad de cifras a redondear a partir de la cantidad de '0' o ''
      'que haya al principio de la cadena, y también si es una máscara numérica
      Dim i As Integer = 0
      While i < value.Length AndAlso (value(i) = "0"c OrElse value(i) = "#")
        i += 1
      End While
      _posiciones = i
      If i > 0 Then
        _decimales = i
        _esMascaraNumerica = True
      Else
        _esMascaraNumerica = False
      End If
      _mascaraSalidaDecimal = value
      If _esMascaraNumerica Then
        _mascaraSalidaDecimalInterna = value.Substring(0, _posiciones) + "'" + value.Substring(_posiciones).Replace("''", [sub].ToString()).Replace("'", [String].Empty).Replace([sub].ToString(), "'") + "'"
      Else
        _mascaraSalidaDecimalInterna = value.Replace("''", [sub].ToString()).Replace("'", [String].Empty).Replace([sub].ToString(), "'")
      End If
    End Set
  End Property

  ''' <summary>
  ''' Indica si la primera letra del resultado debe estár en mayúscula
  ''' </summary>
  Public Property LetraCapital() As Boolean
    Get
      Return _letraCapital
    End Get
    Set(ByVal value As Boolean)
      _letraCapital = value
    End Set
  End Property

  ''' <summary>
  ''' Indica si se deben convertir los decimales a su expresión nominal
  ''' </summary>
  Public Property ConvertirDecimales() As Boolean
    Get
      Return _convertirDecimales
    End Get
    Set(ByVal value As Boolean)
      _convertirDecimales = value
      _apocoparUnoParteDecimal = value
      If value Then
        ' Si la máscara es la default, la borro
        If _mascaraSalidaDecimal = MascaraSalidaDecimalDefault Then
          MascaraSalidaDecimal = ""
        End If
      ElseIf [String].IsNullOrEmpty(_mascaraSalidaDecimal) Then
        MascaraSalidaDecimal = MascaraSalidaDecimalDefault
        'Si no hay máscara dejo la default
      End If
    End Set
  End Property

  ''' <summary>
  ''' Indica si de debe cambiar "uno" por "un" en las unidades.
  ''' </summary>
  Public Property ApocoparUnoParteEntera() As Boolean
    Get
      Return _apocoparUnoParteEntera
    End Get
    Set(ByVal value As Boolean)
      _apocoparUnoParteEntera = value
    End Set
  End Property

  ''' <summary>
  ''' Determina si se debe apococopar el "uno" en la parte decimal
  ''' </summary>
  ''' <remarks>El valor de esta propiedad cambia al setear ConvertirDecimales</remarks>
  Public Property ApocoparUnoParteDecimal() As Boolean
    Get
      Return _apocoparUnoParteDecimal
    End Get
    Set(ByVal value As Boolean)
      _apocoparUnoParteDecimal = value
    End Set
  End Property

#End Region

#Region "Constructores"

  Public Sub New()
    MascaraSalidaDecimal = MascaraSalidaDecimalDefault
    SeparadorDecimalSalida = SeparadorDecimalSalidaDefault
    LetraCapital = LetraCapitalDefault
    ConvertirDecimales = _convertirDecimales
  End Sub

  Public Sub New(ByVal ConvertirDecimales As Boolean, ByVal MascaraSalidaDecimal As String, ByVal SeparadorDecimalSalida As String, ByVal LetraCapital As Boolean)
    If Not [String].IsNullOrEmpty(MascaraSalidaDecimal) Then
      Me.MascaraSalidaDecimal = MascaraSalidaDecimal
    End If
    If Not [String].IsNullOrEmpty(SeparadorDecimalSalida) Then
      _separadorDecimalSalida = SeparadorDecimalSalida
    End If
    _letraCapital = LetraCapital
    _convertirDecimales = ConvertirDecimales
  End Sub

#End Region

#Region "Conversores de instancia"

  Public Function ToCustomCardinal(ByVal Numero As Double) As String
    Return Convertir(Convert.ToDecimal(Numero), _decimales, _separadorDecimalSalida, _mascaraSalidaDecimalInterna, _esMascaraNumerica, _letraCapital,
    _convertirDecimales, _apocoparUnoParteEntera, _apocoparUnoParteDecimal)
  End Function

  Public Function ToCustomCardinal(ByVal Numero As String) As String
    Dim dNumero As Double
    If [Double].TryParse(Numero, NumberStyles.Float, _cultureInfo, dNumero) Then
      Return ToCustomCardinal(dNumero)
    Else
      Throw New ArgumentException("'" + Numero + "' no es un número válido.")
    End If
  End Function

  Public Function ToCustomCardinal(ByVal Numero As Decimal) As String
    Return ToCardinal(Numero)
  End Function

  Public Function ToCustomCardinal(ByVal Numero As Int32) As String
    Return Convertir(Convert.ToDecimal(Numero), 0, _separadorDecimalSalida, _mascaraSalidaDecimalInterna, _esMascaraNumerica, _letraCapital,
    _convertirDecimales, _apocoparUnoParteEntera, False)
  End Function

#End Region

#Region "Conversores estáticos"

  Public Shared Function ToCardinal(ByVal Numero As Int32) As String
    Return Convertir(Convert.ToDecimal(Numero), 0, Nothing, Nothing, True, LetraCapitalDefault,
    ConvertirDecimalesDefault, ApocoparUnoParteEnteraDefault, ApocoparUnoParteDecimalDefault)
  End Function

  Public Shared Function ToCardinal(ByVal Numero As Double) As String
    Return Convertir(Convert.ToDecimal(Numero), DecimalesDefault, SeparadorDecimalSalidaDefault, MascaraSalidaDecimalDefault, True, LetraCapitalDefault,
    ConvertirDecimalesDefault, ApocoparUnoParteEnteraDefault, ApocoparUnoParteDecimalDefault)
  End Function

  Public Shared Function ToCardinal(ByVal Numero As String, ByVal ReferenciaCultural As CultureInfo) As String
    Dim dNumero As Double
    If [Double].TryParse(Numero, NumberStyles.Float, ReferenciaCultural, dNumero) Then
      Return ToCardinal(dNumero)
    Else
      Throw New ArgumentException("'" + Numero + "' no es un número válido.")
    End If
  End Function

  Public Shared Function ToCardinal(ByVal Numero As String) As String
    Return Numalet.ToCardinal(Numero, CultureInfo.CurrentCulture)
  End Function

  Public Shared Function ToCardinal(ByVal Numero As Decimal) As String
    Return ToCardinal(Convert.ToDouble(Numero))
  End Function

#End Region

  Private Shared Function Convertir(ByVal Numero As Decimal, ByVal Decimales As Int32, ByVal SeparadorDecimalSalida As String, ByVal MascaraSalidaDecimal As String, ByVal EsMascaraNumerica As Boolean, ByVal LetraCapital As Boolean,
  ByVal ConvertirDecimales As Boolean, ByVal ApocoparUnoParteEntera As Boolean, ByVal ApocoparUnoParteDecimal As Boolean) As String
    Dim Num As Int64
    Dim terna As Int32, centenaTerna As Int32, decenaTerna As Int32, unidadTerna As Int32, iTerna As Int32
    Dim cadTerna As String
    Dim Resultado As New StringBuilder()

    Num = Math.Floor(Math.Abs(Numero))

    If Num >= 1000000000001 OrElse Num < 0 Then
      Throw New ArgumentException("El número '" + Numero.ToString() + "' excedió los límites del conversor: [0;1.000.000.000.001]")
    End If
    If Num = 0 Then
      Resultado.Append(" cero")
    Else
      iTerna = 0

      Do Until Num = 0

        iTerna += 1
        cadTerna = String.Empty
        terna = Num Mod 1000

        centenaTerna = Int(terna / 100)
        decenaTerna = terna - centenaTerna * 100 'Decena junto con la unidad
        unidadTerna = (decenaTerna - Math.Floor(decenaTerna / 10) * 10)

        Select Case decenaTerna
          Case 1 To 9
            cadTerna = _matriz(UNI, unidadTerna) + cadTerna
          Case 10 To 19
            cadTerna = cadTerna + _matriz(DIECI, unidadTerna)
          Case 20
            cadTerna = cadTerna + " veinte"
          Case 21 To 29
            cadTerna = " veinti" + _matriz(UNI, unidadTerna).Substring(1)
          Case 30 To 99
            If unidadTerna <> 0 Then
              cadTerna = _matriz(DECENA, Int(decenaTerna / 10)) + " y" + _matriz(UNI, unidadTerna) + cadTerna
            Else
              cadTerna += _matriz(DECENA, Int(decenaTerna / 10))
            End If
        End Select

        Select Case centenaTerna
          Case 1
            If decenaTerna > 0 Then
              cadTerna = " ciento" + cadTerna
            Else
              cadTerna = " cien" + cadTerna
            End If
            Exit Select
          Case 5, 7, 9
            cadTerna = _matriz(CENTENA, Int(terna / 100)) + cadTerna
            Exit Select
          Case Else
            If Int(terna / 100) > 1 Then
              cadTerna = _matriz(UNI, Int(terna / 100)) + "cientos" + cadTerna
            End If
            Exit Select
        End Select
        'Reemplazo el 'uno' por 'un' si no es en las únidades o si se solicító apocopar
        If (iTerna > 1 OrElse ApocoparUnoParteEntera) AndAlso decenaTerna = 21 Then
          cadTerna = cadTerna.Replace("veintiuno", "veintiún")
        ElseIf (iTerna > 1 OrElse ApocoparUnoParteEntera) AndAlso unidadTerna = 1 AndAlso decenaTerna <> 11 Then
          cadTerna = cadTerna.Substring(0, cadTerna.Length - 1)
          'Acentúo 'veintidós', 'veintitrés' y 'veintiséis'
        ElseIf decenaTerna = 22 Then
          cadTerna = cadTerna.Replace("veintidos", "veintidós")
        ElseIf decenaTerna = 23 Then
          cadTerna = cadTerna.Replace("veintitres", "veintitrés")
        ElseIf decenaTerna = 26 Then
          cadTerna = cadTerna.Replace("veintiseis", "veintiséis")
        End If

        'Completo miles y millones
        Select Case iTerna
          Case 3
            If Numero < 2000000 Then
              cadTerna += " millón"
            Else
              cadTerna += " millones"
            End If
          Case 2, 4
            If terna > 0 Then cadTerna += " mil"
        End Select
        Resultado.Insert(0, cadTerna)
        Num = Int(Num / 1000)
      Loop
    End If

    'Se agregan los decimales si corresponde
    If Decimales > 0 Then
      Resultado.Append(" " + SeparadorDecimalSalida + " ")
      Dim EnteroDecimal As Int32 = Int(Math.Round((Numero - Int(Numero)) * Math.Pow(10, Decimales)))
      If ConvertirDecimales Then
        Dim esMascaraDecimalDefault As Boolean = MascaraSalidaDecimal = MascaraSalidaDecimalDefault
        Resultado.Append(Convertir(Convert.ToDecimal(EnteroDecimal), 0, Nothing, Nothing, EsMascaraNumerica, False,
        False, (ApocoparUnoParteDecimal AndAlso Not EsMascaraNumerica), False) + " " + (IIf(EsMascaraNumerica, "", MascaraSalidaDecimal)))
      ElseIf EsMascaraNumerica Then
        Resultado.Append(EnteroDecimal.ToString(MascaraSalidaDecimal))
      Else
        Resultado.Append(EnteroDecimal.ToString() + " " + MascaraSalidaDecimal)
      End If
    End If
    'Se pone la primer letra en mayúscula si corresponde y se retorna el resultado
    If LetraCapital Then
      Return Resultado(1).ToString().ToUpper() + Resultado.ToString(2, Resultado.Length - 2)
    Else
      Return Resultado.ToString().Substring(1)
    End If
  End Function

End Class