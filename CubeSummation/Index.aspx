<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CubeSummation.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head >
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>

    <script type="text/javascript">
        function CallAJAX() {
            var t = $('#variableT').val();
            var n = $('#variableN').val();
            var m = $('#variableM').val();
            
            $.ajax({
                type: 'POST',
                dataType: 'json',
                contentType: 'application/json',
                url: 'Index.aspx/validar',
                data: '{t: '+ t +', n: ' + n +', m: ' + m + '}',
                success:
                    function (response) {
                        
                        if (response.d == true) {
                            alert("Valores correctos");                            

                        } else {
                            alert("Valores incorrectos");
                        }
                    }
            });
        }

        function Update() {
            var x = $('#x').val();
            var y = $('#y').val();
            var z = $('#z').val();
            var w = $('#w').val();
            
            $.ajax({
                type: 'POST',
                dataType: 'json',
                contentType: 'application/json',
                url: 'Index.aspx/update',
                data: '{x: '+ x +', y: ' + y +', z: ' + z + ', w: ' + w +'}',
                success:
                    function (response) {
                        alert(response.d);  
                           
                    }
            });
        }

        function Query() {
            var x1 = $('#x1').val();
            var y1 = $('#y1').val();
            var z1 = $('#z1').val();
                    
            var x2 = $('#x2').val();
            var y2 = $('#y2').val();
            var z2 = $('#z2').val();
            
            $.ajax({
                type: 'POST',
                dataType: 'json',
                contentType: 'application/json',
                url: 'Index.aspx/query',
                data: '{x1: '+ x1 +', y1: ' + y1 +', z1: ' + z1 + ', x2: ' + x2 +', y2: ' + y2 +', z2: ' + z2 + '}',
                success:
                    function (response) {
                        alert(response.d);  
                        //if (response.d == true) {
                        //    alert("Valores correctos");                            

                        //} else {
                        //    alert("Valores incorrectos");
                        //}
                    }
            });
        }

        function Resultado() {


            $.ajax({
                type: 'POST',
                dataType: 'json',
                contentType: 'application/json',
                url: 'Index.aspx/getResult',
                data: '{}',
                success:
                    function (response) {
                        alert(response.d);
                        //if (response.d == true) {
                        //    alert("Valores correctos");                            

                        //} else {
                        //    alert("Valores incorrectos");
                        //}
                    }
            });
        }


            
        
    </script>

</head>
<body>
    <!-- Page Navbar -->
    <%--<div class="navbar navbar-inverse navbar-fixed-top headroom">
		<div class="container">
			<div class="navbar-header">
				<a class="navbar-brand" href="#"><img src="images/logoCCB.gif" alt="Cube Summation" height="57"/></a>
			</div>
		</div>
	</div>--%>
    <section>
        <div class="container">
            <header>
                <div>
                    <h1>Cube Summation</h1>
                </div>
            </header>
        </div>
    </section>

    <section>
        <div class="container">
            <form id="mainForm" style="padding:2%;">
                   <div class="row">
                       <div class="col-sm-3">
                           <label for="variableT">Ingresar variable T:</label>
                           <input type="number" class="form-control" id="variableT" placeholder="Ingresar variable T" required="required">
                       </div>
                       <div class="col-sm-3">
                           <label for="variableN">Ingresar variable N:</label>
                           <input type="number" class="form-control" id="variableN" placeholder="Ingresar variable N" required="required">
                       </div>
                       <div class="col-sm-3">
                           <label for="variableM">Ingresar variable M:</label>
                           <input type="number" class="form-control" id="variableM" placeholder="Ingresar variable M" required="required">
                       </div>
                   </div>
                   
                   <div class="row">
                       <div class="col-sm-3" style="margin-top:2%;">                  
                           <a href="#" class="btn btn-success" onclick="javascript:CallAJAX();">Submit</a>
                       </div>               
                   </div>
                   
               </form>
            
        </div>
    </section>
    
    <section>
        <div class ="container">
            <div class="row">
                <div class="col-sm-12">
                    <ul class="nav nav-tabs">
                        <li class="active"><a href="#home">Update</a></li>
                        <li><a href="#menu1">Query</a></li>
      
                     </ul>
                </div>
                
            </div>
        </div>
    </section>

    <section>
        <div class="container">
            <div class="tab-content">
                <div id="home" class="tab-pane fade in active" style ="padding:2%;>
                  <form id="formUpdate">
                           <div class="col-sm-3">
                               <label for="x">Ingresar X:</label>
                               <input type="number" class="form-control" id="x" required="required">
                           </div>
                           <div class="col-sm-3">
                               <label for="y">Ingresar Y:</label>
                               <input type="number" class="form-control" id="y" required="required">
                           </div>
                           <div class="col-sm-3">
                               <label for="z">Ingresar Z</label>
                               <input type="number" class="form-control" id="z" required="required">
                           </div>

                      <div class="col-sm-3">
                               <label for="w">Ingresar W</label>
                               <input type="number" class="form-control" id="w" required="required">
                           </div>
                           <div class="row">

                           </div>
                           <div class="col-sm-3" style="margin-top:2%;">
                  
                               <a href="#" class="btn btn-success" onclick="javascript:Update();">Update</a>
                           </div>               
                       </form>
                </div>
            <div id="menu1" class="tab-pane fade">
             <form id="formQuery" style ="padding:2%;">
                       <div class="col-sm-4">
                           <label for="x1">Ingresar X1:</label>
                           <input type="number" class="form-control" id="x1" required="required">
                       </div>
                       <div class="col-sm-4">
                           <label for="y1">Ingresar Y1:</label>
                           <input type="number" class="form-control" id="y1" required="required">
                       </div>
                       <div class="col-sm-4">
                           <label for="z1">Ingresar Z1</label>
                           <input type="number" class="form-control" id="z1" required="required">
                       </div>

                 <div class="col-sm-4">
                           <label for="x2">Ingresar X2:</label>
                           <input type="number" class="form-control" id="x2" required="required">
                       </div>
                       <div class="col-sm-4">
                           <label for="y2">Ingresar Y2:</label>
                           <input type="number" class="form-control" id="y2" required="required">
                       </div>
                       <div class="col-sm-4">
                           <label for="z2">Ingresar Z2</label>
                           <input type="number" class="form-control" id="z2" required="required">
                       </div>
                       <div class="col-sm-4" style="margin-top:2%;">
                  
                           <a href="#" class="btn btn-success" onclick="javascript:Query();">Query</a>
                       </div>    
         
                     <div class="col-sm-4" style="margin-top:2%;">
                  
                           <a href="#" class="btn btn-success" onclick="javascript:Resultado();">Resultados</a>
                       </div>               
                   </form>
            </div>
        </div>
    </section>
        

             

  
    
  </div>


   
    <script>
$(document).ready(function(){
    $(".nav-tabs a").click(function(){
        $(this).tab('show');
    });
});
</script>
    <script src="Scripts/bootstrap.js"></script>
</body>
</html>
