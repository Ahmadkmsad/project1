<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>My Food Delivery App</title>
    <style>
       *{
           margin:0;
           padding:0;
       }
       #navbar{
           display:flex;
           align-items:center;
           position:relative;
       }

        #navbar::before {
            content: "";
            background-color: black;
            position: absolute;
            height: 100%;
            width: 100%;
            z-index:-1;
            opacity:0.4;
        }

       #logo{
           margin:3px;
          
       }
       #logo img{
                        height: 63px;
                        width: 67px;

       }
       .item{
           display:inline;
       }
       #navbar ul a{
           color:white;
           margin: 35px;
           font-size:20px;
           text-decoration:none;
       }
       #navbar ul a:hover{
           color:black;
           background:white;
           border-radius:8px;
          
       }
       #home{
           display:flex;
           flex-direction:column;
           padding-top:3px;
           padding-left:20px;
           align-items:center;
           justify-content:center;


       }
        #home::before {
            content: "";
            position: absolute;
            background-image: url('bg.jpg');
            background-repeat: no-repeat;
            background-position: center;
            background-size: cover;
            height: 100%;
            width: 100%;
            z-index: -1;
            opacity: 0.3;
        }
    </style>

</head>
<body>
   <nav id="navbar">
       <div id="logo">
           <img src="logo.png" accesskey="logo" />
       </div>

       <ul>
           <li class="item"><a href="#">Home</a></li>
           <li class="item"><a href="#">services</a></li>
           <li class="item"><a href="#">About Us</a></li>
           <li class="item"><a href="#">Contact Us</a></li>

       </ul>
   </nav>
   <section id="home">
       <h1 class="head">
           Welcome to oline bakery
       </h1>
       <p class="para">
           Bread & Beyond Online Bakery offers a huge choice of Pizza Deals, Bread, Bakery Items, Chicken Sandwich, Sweets, Cake, and other products.
           Order Bakery Online at Carrefour Pakistan. Get the latest offers and shop from a large selection of products in Pakistan. Great deals with up to 70% off.
       </p>

       <p class="para">At Sweet Affairs we say you should start with dessert. It's hard to disagree with when it comes to our freshly baked pastries, cookies, breads, tarts, and more.</p>
       <button class="button">order Now</button>
    </section>
</body>
</html>
