<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prueba.aspx.cs" Inherits="ActiveSmartWeb.Prueba" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
        


    <script src="https://cdnjs.cloudflare.com/ajax/libs/Chart.js/3.9.1/chart.min.js" integrity="sha512-ElRFoEQdI5Ht6kZvyzXhYG9NqjtkmlkfYk0wr6wHxU9JEHakS7UJZNeml5ALk+8IKlU6jDgMabC3vkumRokgJA==" crossorigin="anonymous" referrerpolicy="no-referrer"></script>
    <script src="https://ajax.googleapis.com/ajax/libs/webfont/1.6.26/webfont.js" type="text/javascript"></script>


<script>


   



    const ctx = document.getElementById('myChart').getContext('2d');
    const myChart = new Chart(ctx, {
        type: 'pie',
        data: {
            labels: ['No Encontrados', 'Vencidos', 'Encontrados'],
            datasets: [{
                //label: '# of Votes',
                data: [12, 19, 3],
                backgroundColor: [
                    'rgba(212, 108, 20)',
                    'rgba(68, 68, 68)',
                    'rgba(244, 204, 68)'
                ],
                borderColor: [
                    'rgba(249, 243, 220)',
                    'rgba(249, 243, 220)',
                    'rgba(249, 243, 220)'
                ],
                borderWidth: 2
            }]
        },
        options: {
            
        }
    });
</script>
</body>
</html>
