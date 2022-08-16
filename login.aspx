<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="proyecto1VanessaAlvaradoS.login" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
  <link rel="stylesheet" type="text/css" href="css/login.css">

</head>
<body>
  <div class="overlay">
<!-- LOGN IN FORM by Omar Dsoky -->
      <form id="form1" runat="server">
   <!--   con = Container  for items in the form-->
   <!--     Start  header Content  -->
   <header class="head-form">
      <h2>Inicio Sesion</h2>
      <!--    Mensaje Bienvenida -->
      <p>Bienvenido ingrese usuario y contraseña</p>
   </header>
   <!--     End  header Content  -->
   <br>
   <div class="field-set">
     
      <!--   user name -->
         <span class="input-item">
           <i class="fa fa-user-circle"></i>
         </span>
        <!--   user name Input-->
         <input class="form-input" id="tUsuario" type="text" placeholder="Usuario:">
     
      <br>
     
           <!--   Password -->
     
      <span class="input-item">
        <i class="fa fa-key"></i>
       </span>
      <!--   Password Input-->
      <input class="form-input" type="password" placeholder="Password" id="tClave"  name="Contraseña">
     
<!--      Show/hide password  -->
     <span>
        <i class="fa fa-eye" aria-hidden="true"  type="button" id="eye"></i>
     </span>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
<!--        buttons -->
<!--      button LogIn -->
     <!--      End Other the Division -->
       <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <asp:Button ID="bIngresar" runat="server" CssClass="button button1" Height="44px" OnClick="bRegistro_Click" Text="Ingresar" Width="122px" />
       &nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <a href="Registrarse.aspx" font-family: 'Vibur', cursive >
         Registrarse </a>     
<!--   End Conrainer  -->
  </div>
  
  <!-- End Form -->
      </form>
</div>
</body>
</html>
