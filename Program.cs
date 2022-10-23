<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="viewport" content="initial-scale=1, maximum-scale=1">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">
    <title>Ecommerce Website</title>
</head>
<style>
    * {

        margin: 0;
        padding: 0;
    }

    .main {
        margin: 0px auto;
        width: 1000px;
    }

    .navigation_bar {

        background-color: black;
        width: 100%;
        margin: 0 auto;
        text-align: center;
    }

    .navigation_bar ul {

        margin: 0px;
        padding: 10px;
        display: inline-block;
    }

    .navigation_bar li {
        list-style-type: none;
        float: left;
        font-size: 20px;

        padding: 6px 10px 0px 10px;
    }

    .navigation_bar li a {

        text-decoration-line: none;
        color: grey;
    }




    .bg_main::before {

        content: '';
        background: url(images/banner.png) no-repeat center center/cover;
        position: absolute;
        opacity: 0.95;
        top: 8%;
        left: 0px;
        width: 100%;
        height: 100vh;
        z-index: -1;
        max-width: 100%;

    }

    .img_logo {
        margin-top: 2.5%;
        width: 20%;
        float: left;
        text-align: center;
        padding: 0px 0px;
    }
    .img_logo img{
        width: 50%;
        height :auto;
    }

   

    

    

    form.search_bar input[type=text] {
        padding: 10px;
        font-size: 17px;
        border: 1px solid grey;
        float: left;
        width: 80%;
        background: #f1f1f1;
    }

    form.search_bar button {
        float: left;
        width: 10%;
        padding: 10px;

        color: white;
        font-size: 17px;
        border: 1px solid;
        border-left: none;
        cursor: pointer;
        border-radius: 3px;
    }

    form.search_bar button {
        background-color: #f26522;
        border-color: #f26522
    }

    form.search_bar::after {
        content: "";
        clear: both;
        display: table;
    }




    .login_Cart {
        margin-top: 15%;
        display: flex;
        text-align: right;
        float: right;
    }

    .login_Cart ul {
        margin: 0px;
        padding: 0px;
    }

    .login_Cart li {
        list-style: none;
        float: left;
        font-size: 16px;
        color: white;
        text-transform: uppercase;
        padding-left: 10px;
        padding-top: 4px;
    }

    .login_Cart li a {
        text-decoration-line: none;
        color: white;
    }


    
    .head_box {
        
        display: flex;
    }

    .banner_text {
        margin-top: 10%;
        width: 100%;
        font-size: 60px;
        color: #ffffff;
        text-align: center;
        text-transform: uppercase;
        font-weight: bold;
    }

    .buynow_button {
        width: 170px;
        margin: 0 auto;
        padding-top: 30px;
    }

    .buynow_button a {
        text-decoration-line: none;
        width: 100%;
        float: left;
        font-size: 16px;
        color: #ffffff;
        background-color: #252525;
        text-align: center;
        padding: 10px 0px;
        border-radius: 5px;
        text-transform: uppercase;
        font-weight: bold;
    }

    .buynow_button a:hover {
        background-color: #f26522;
        color: #ffffff;
    }
    .search_bar{
        margin-top: 2.5%;
        float: left;
        
        width: 60%;
    }
    .clear{
        clear: both;
    }
    .items_heading {
        width: 100%;
        font-size: 40px;
        color: #30302e;
        text-align: center;
        font-weight: bold;
    }

    .items_mainbox {
        width: 100%;
        float: left;
        padding-bottom: 150px;
        width: 100%;
        background-color: #ffffff;
        height: auto;
        padding: 0px;
        box-shadow: 0px 0 30px 10px #f0f0f0;
        margin-bottom: 20px;
    }

    .shirttext {
        width: 100%;
        font-size: 20px;
        color: #30302e;
        text-align: center;
        font-weight: bold;
        padding-bottom: 5px;
    }

    .pricetext {
        width: 100%;
        font-size: 16px;
        color: #f26522;
        text-align: center;
        margin: 0px;
    }

    .tshirtimage {
        width: 100%;
        text-align: center;
        margin: 50px 0px;
        min-height: 370px;
    }

    .button_main {

        width: 100%;
        display: flex;
    }

    .buy_button {
        padding: 20px;
        float: left;
        width: 100%;
    }

    .buy_button a {

        text-decoration-line: none;
        width: 100%;
        font-size: 16px;
        color: #f26522;
        background-color: transparent;
        text-align: right;
        font-weight: bold;
    }

    .buy_button a:hover {
        background-color: transparent;
        color: #262626;
    }

    .seemore_button {
        padding: 25px;
        width: 100%;
        float: right;
        text-align: right;
    }

    .seemore_button a {

        text-decoration-line: none;
        width: 100%;
        font-size: 16px;
        color: #262626;
        background-color: transparent;
        text-align: right;
    }

    .seemore_button a:hover {
        background-color: transparent;
        color: #f26522;
    }

    .fashion_section {

        width: 30%;
        float: left;

        padding: 10px;
    }

    .electronic_images {
        width: 100%;
        text-align: center;
        margin: 50px 0px;
        min-height: 293px;
    }

    .jewelleryimages {
        width: 100%;
        text-align: center;
        margin: 50px 0px;
        max-height: 293px;
    }

    .clear1 {
        
        margin-top: 15%;
        margin-bottom: 30px;
        clear: both;
    }
    .pad{
        padding-left: 10%;
        padding-right: 10%;
    }
    .foot_sect {
            height: auto;
            float: left;
            background-color:#252525;
            width: 100%;
        }

        .foot_logo {

            padding-top: 30px;
            width: 100%;
            justify-content: center;
            text-align: center;
        }


        .footbar_menu {
            width: 100%;
            margin: 0 auto;
            text-align: center;
        }

        .footbar_menu ul {
            margin: 0px;
            padding: 0px;
            display: inline-block;
        }

        .footbar_menu li {
            list-style-type: none;
            float: left;

            color: #f1f1f1;
            padding: 20px 10px 0px 10px;
            font-size: 16px;
        }

        .footbar_menu li a {
            text-decoration-line: none;
            color: #f1f1f1;
        }

        .footbar_menu li a:hover {
            color: #f26522;
        }

        .loca_main {
            float: left;
            font-size: 16px;
            color: #ffffff;
            width: 100%;
            margin: 0 auto;
            padding-top: 30px;
            text-align: center;
        }

        .copyright {
            padding-bottom: 20px;
            width: 100%;
            float: left;
            background-color: #252525;
            height: auto;
        }

        .copyrighttext {
            width: 100%;
            float: left;
            color: #ffffff;
            text-align: center;
            font-size: 17px;
            margin: 20px 0px;
        }

        .copyrighttext a:hover {
            color: #f26522;
        }

        .line {
            margin-top: 20px;
            width: 40%;
            text-align: center;
            margin-left: 30%;
        }

        .clear2 {
            clear: both;
            margin-top: 20%;
        }
</style>

<body>

    <nav class="navigation_bar">
        <ul>
            <li><a href="#">Best Sellers</a></li>
            <li><a href="#">Gift Ideas</a></li>
            <li><a href="#">New Releases</a></li>
            <li><a href="#">Today's Deals</a></li>
            <li><a href="#">Customer Service</a></li>
        </ul>
    </nav>

    <div class="bg_main">
        <div class="main img_logo"><a href=""><img src="images/logo.png" alt=""></a></div>

        <form class="main search_bar">
            <input type="text" placeholder="Search..">
            <button class="main buttonsearch"  type="submit"><i class=" fa fa-search "></i></button>
        </form>


        <div class="head_box">
            <div class="login_Cart">
                <ul>
                    <li><a href="#">
                            <i class="fa fa-shopping-cart"></i>
                            <span class="padding_10">Cart</span></a>
                    </li>
                    <li><a href="#">
                            <i class="fa fa-user"></i>
                            <span class="padding_10">Login</span></a>
                    </li>
                </ul>
            </div>
        </div>
        
        <div class="clear">
            <h1 class="banner_text">Get Start <br>Your favriot shoping</h1>
           
            <div class="buynow_button"><a href="#">Buy Now</a></div>
        </div>
    </div>

    <div class="clear1"">
        <h2 class=" items_heading">Man & Woman Fashion</h2>
    </div>
    <div class="pad">
    <div class="main fashion_section">
        <div class="items_mainbox  ">
            <h4 class="shirttext">Man T -shirt</h4>
            <p class="pricetext">Price <span style="color: #262626;">$ 30</span></p>
            <div class="tshirtimage"><img src="images/polo-shirt-png-free-download-13.png"></div>
            <div class="button_main">
                <div class="buy_button"><a href="#">Buy Now</a></div>
                <div class="seemore_button"><a href="#">See More</a></div>
            </div>
        </div>
    </div>
    <div class="main fashion_section">
        <div class="items_mainbox  ">
            <h4 class="shirttext">shirt</h4>
            <p class="pricetext">Price <span style="color: #262626;">$ 30</span></p>
            <div class="tshirtimage"><img src="images/dress_shirt_PNG8083.png"></div>
            <div class="button_main">
                <div class="buy_button"><a href="#">Buy Now</a></div>
                <div class="seemore_button"><a href="#">See More</a></div>
            </div>
        </div>
    </div>
    <div class="main fashion_section">
        <div class="items_mainbox  ">
            <h4 class="shirttext">scarf</h4>
            <p class="pricetext">Price <span style="color: #262626;">$ 30</span></p>
            <div class="tshirtimage"><img src="images/women-clothes-png-1.png"></div>
            <div class="button_main">
                <div class="buy_button"><a href="#">Buy Now</a></div>
                <div class="seemore_button"><a href="#">See More</a></div>
            </div>
        </div>
    </div>
    </div>
   
    <div class="clear1"">
        <h2 class=" items_heading">Electronic</h2>
    </div>
    <div class="pad">
    <div class="fashion_section">
        <div class="items_mainbox  ">
            <h4 class="shirttext">Laptop</h4>
            <p class="pricetext">Price <span style="color: #262626;">$ 30</span></p>
            <div class="electronic_images"><img src="images/laptop.png"></div>
            <div class="button_main">
                <div class="buy_button"><a href="#">Buy Now</a></div>
                <div class="seemore_button"><a href="#">See More</a></div>
            </div>
        </div>
    </div>
    <div class="fashion_section">
        <div class="items_mainbox  ">
            <h4 class="shirttext">Mobile</h4>
            <p class="pricetext">Price <span style="color: #262626;">$ 30</span></p>
            <div class="electronic_images"><img src="images/mobile.png"></div>
            <div class="button_main">
                <div class="buy_button"><a href="#">Buy Now</a></div>
                <div class="seemore_button"><a href="#">See More</a></div>
            </div>
        </div>
    </div>
    <div class="fashion_section">
        <div class="items_mainbox  ">
            <h4 class="shirttext">Computer</h4>
            <p class="pricetext">Price <span style="color: #262626;">$ 30</span></p>
            <div class="electronic_images"><img src="images/computer.png"></div>
            <div class="button_main">
                <div class="buy_button"><a href="#">Buy Now</a></div>
                <div class="seemore_button"><a href="#">See More</a></div>
            </div>
        </div>
    </div>
    </div>
    <div class="clear1"">
        <h2 class=" items_heading">Jewellery Accessories</h2>
    </div>
    <div class="pad">
    <div class="fashion_section">
        <div class="items_mainbox  ">
            <h4 class="shirttext">Jumkas</h4>
            <p class="pricetext">Price <span style="color: #262626;">$ 30</span></p>
            <div class="jewelleryimages"><img src="images/jhumkas.png"></div>
            <div class="button_main">
                <div class="buy_button"><a href="#">Buy Now</a></div>
                <div class="seemore_button"><a href="#">See More</a></div>
            </div>
        </div>
    </div>
    <div class="fashion_section">
        <div class="items_mainbox  ">
            <h4 class="shirttext">Necklaces</h4>
            <p class="pricetext">Price <span style="color: #262626;">$ 30</span></p>
            <div class="jewelleryimages"><img src="images/necklaces.png"></div>
            <div class="button_main">
                <div class="buy_button"><a href="#">Buy Now</a></div>
                <div class="seemore_button"><a href="#">See More</a></div>
            </div>
        </div>
    </div>
    <div class="fashion_section">
        <div class="items_mainbox  ">
            <h4 class="shirttext">Kangans</h4>
            <p class="pricetext">Price <span style="color: #262626;">$ 30</span></p>
            <div class="jewelleryimages"><img src="images/kangan.png"></div>
            <div class="button_main">
                <div class="buy_button"><a href="#">Buy Now</a></div>
                <div class="seemore_button"><a href="#">See More</a></div>
            </div>
        </div>
    </div>
    </div>

    <divclass="clear2">
        </div>
        <div class="foot_sect">

            <div class="foot_logo"><a href="index.html"><img src="images/logo.png"></a></div>
            <div class="line">
                <hr>
            </div>
            <div class="footbar_menu">
                <ul>
                    <li><a href="#">Best Sellers</a></li>
                    <li><a href="#">Gift Ideas</a></li>
                    <li><a href="#">New Releases</a></li>
                    <li><a href="#">Today's Deals</a></li>
                    <li><a href="#">Customer Service</a></li>
                </ul>
            </div>
            <div class="loca_main">Help Line Number : +1 1800 1200 1200</div>

        </div>
        <div class="copyright">
            <p class="copyrighttext">© 2020 All Rights Reserved. Design by Free html Templates</p>

        </div>



</body>

</html>
