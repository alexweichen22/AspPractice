<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="stylesheets/mystyle.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    
    <div id="PageWrapper">
        
        <div id="Header"> Header Goes Here</div>
        
        <div id="MenuWrapper">Menu Goes Here</div>
        
        <div id="MainContent">
        
            <h1>Hi there visitor and welcome to Chiarelli ELearning</h1>

            <p class="Introduction">I am glad you are paying a visit to my site,                
                <a href="https://www.youtube.com/user/cchiarelli/">Chiarelli</a>, the <span class="red">coolest</span> 
                Elearning community on the Internet.
            </p>

            <p>Feel free to have a look around as there are <span class="red">lots</span> of 
                <span class="Introduction">interesting</span> educational videos to be found here
            </p>
        
        </div>
        
        <div id="Sidebar">Sidebar Goes Here</div>
        
        <div id="Footer">Footer Goes Here</div>

    </div>

    </form>
</body>
</html>
