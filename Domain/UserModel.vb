Imports System.Data
Imports DataAccess
Imports System.Runtime.InteropServices

Public Class UserModel
    Dim userDao As New UserDao()

    Public Function Login(user As String, pass As String) As Boolean
        Return userDao.Login(user, pass)
    End Function

    Public Function InsertarProducto(codigo As String, desc As String, cantP As Integer, cantA As Integer, costo As Single, porcentaje As Single, precio As Single) As Boolean
        Return userDao.InsertarProducto(codigo, desc, cantP, cantA, costo, porcentaje, precio)
    End Function
    Public Function AcumularProducto(codigo As String, desc As String, cantP As Integer, cantA As Integer, costo As Single, porcentaje As Single, precio As Single) As Boolean
        Return userDao.AcumularProducto(codigo, desc, cantP, cantA, costo, porcentaje, precio)
    End Function
    Public Function ComprarProductos(codigo As String, desc As String, cantP As Integer, proveedor As String, costo As Single, porcentaje As Single, precio As Single) As Boolean
        Return userDao.ComprarProductosUserDao(codigo, desc, cantP, proveedor, costo, porcentaje, precio)
    End Function
    Public Function RestarDinero(totalCaja As Double, totalTesoro As Double, totalDeuda As Double, totalBanco As Double, proveedor As String) As Boolean
        Return userDao.RestarDineroUserDao(totalCaja, totalTesoro, totalDeuda, totalBanco, proveedor)
    End Function

    Public Function PagarProveedor(totalCaja As Double, totalTesoro As Double, totalBanco As Double, total As Double, proveedor As String) As Boolean
        Return userDao.PagarProveedorUserDao(totalCaja, totalTesoro, totalBanco, total, proveedor)
    End Function



    Public Function BajarProductosDeStockAndAcopio(codigo As String, cant As Double, cliente As String) As Boolean
        Return userDao.BajarProductosDeStockAndAcopioUserDao(codigo, cant, cliente)
    End Function

    Public Function VenderProductos(codigo As String, cant As Double, vendedor As String, codVenta As Integer) As Boolean
        Return userDao.VenderProductosUserDao(codigo, cant, vendedor, codVenta)
    End Function

    Public Function VenderProductosAcopio(codigo As String, cant As Double, vendedor As String, codVenta As Integer, codCli As String) As Boolean
        Return userDao.VenderProductosAcopioUserDao(codigo, cant, vendedor, codVenta, codCli)
    End Function
    Public Function InsertarEnConfirmar(total As Single, ajuste As Single, efectivo As Single, tarjeta As Single, interes As Single, cliente As String) As Integer
        Return userDao.InsertarEnConfirmarUserDao(total, ajuste, efectivo, tarjeta, interes, cliente)
    End Function

    Public Function cargarEnCaja(total As Single, efectivo As Single, tarjeta As Single, codVenta As Integer) As Boolean
        Return userDao.cargarEnCajaUserDao(total, efectivo, tarjeta, codVenta)
    End Function

    Public Function cargarEnCajaCobro(total As Single, efectivo As Single, tarjeta As Single, tarjetaSinInteres As Single, codCli As Integer) As Boolean
        Return userDao.cargarEnCajaCobroUserDao(total, efectivo, tarjeta, tarjetaSinInteres, codCli)
    End Function

    Public Function Pagar(pago As Double, sucursal As String, descripcion As String) As Boolean
        Return userDao.PagarUserDao(pago, sucursal, descripcion)
    End Function

    Public Function PagarTesoro(pago As Double, sucursal As String, descripcion As String) As Boolean
        Return userDao.PagarTesoroUserDao(pago, sucursal, descripcion)
    End Function

    Public Function CerrarCaja(efectivo As Double) As Boolean
        Return userDao.CerrarCajaUserDao(efectivo)
    End Function

    Public Function Comprobar(pass As String, objeto As String) As Boolean
        Return userDao.ComprobarUserDao(pass, objeto)
    End Function

    Public Function Retiro(efectivo As Double) As Boolean
        Return userDao.RetiroUserDao(efectivo)
    End Function

    Public Function eliminarVenta(codVenta As Integer) As Boolean
        Return userDao.eliminarVentaUserDao(codVenta)
    End Function

    Public Function RetirarTesoro(total As Double) As Boolean
        Return userDao.RetirarTesoroUserDao(total)
    End Function

    Public Function agregarCliente(nombre As String) As Boolean
        Return userDao.agregarClienteUserDao(nombre)
    End Function
    Public Function agregarProveedor(nombre As String) As Boolean
        Return userDao.agregarProveedorUserDao(nombre)
    End Function

    Public Function descontarSaldoCliente(total As Single, ajuste As Single, efectivo As Single, tarjeta As Single, interes As Single, nombre As String) As Integer
        Return userDao.descontarSaldoClienteUserDao(total, ajuste, efectivo, tarjeta, interes, nombre)
    End Function




End Class
