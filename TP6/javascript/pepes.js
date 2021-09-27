

function Validar() {

    if( $('#txtNombre').val().length == 0)
    {
        window.alert("El campo Nombre esta vacio.");
    }

    if($('#txtApellido').val().length == 0)
    {
        window.alert("El campo apellido esta vacio.");
    }

}

function Limpiar()
{
    $('#txtNombre').val('');
    $('#txtApellido').val('');
    $('#txtEmpresa').val('');
    $('#txtEdad').val('');
}
