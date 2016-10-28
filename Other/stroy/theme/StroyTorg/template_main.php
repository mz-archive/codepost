<?php if(!defined('IN_GS')){ die('you cannot load this page directly.'); }
/****************************************************
*
* @File:        header.inc.php
* @Package:     GetSimple
* @Action:      Summit theme for GetSimple CMS
*
*****************************************************
/
/ Theme adapted by osDesk.org for GetSimple CMS 3.1.2
/ Based on Recreation from freecsstemplates.org
/ Creative Commons Attribution 2.5 License
/ Header graphic from morguefile.com/license/morguefile
/
*****************************************************/
?>

<!DOCTYPE HTML>
<html>
<head>
    <meta charset="utf-8">
    <title><?php get_page_clean_title(); ?></title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    
    
    <link href="<?php get_theme_url(); ?>/scripts/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link href="<?php get_theme_url(); ?>/scripts/bootstrap/css/bootstrap-responsive.min.css" rel="stylesheet">

    <!-- Le HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="http://html5shim.googlecode.com/svn/trunk/html5.js"></script>
    <![endif]-->

    <!-- Icons -->
    <link href="<?php get_theme_url(); ?>/scripts/icons/general/stylesheets/general_foundicons.css" media="screen" rel="stylesheet" type="text/css" />  
    <link href="<?php get_theme_url(); ?>/scripts/icons/social/stylesheets/social_foundicons.css" media="screen" rel="stylesheet" type="text/css" />
    <!--[if lt IE 8]>
        <link href="scripts/icons/general/stylesheets/general_foundicons_ie7.css" media="screen" rel="stylesheet" type="text/css" />
        <link href="scripts/icons/social/stylesheets/social_foundicons_ie7.css" media="screen" rel="stylesheet" type="text/css" />
    <![endif]-->
    <link rel="stylesheet" href="<?php get_theme_url(); ?>/scripts/fontawesome/css/font-awesome.min.css">
    <!--[if IE 7]>
        <link rel="stylesheet" href="scripts/fontawesome/css/font-awesome-ie7.min.css">
    <![endif]-->

<link href="<?php get_theme_url(); ?>/scripts/carousel/style.css" rel="stylesheet" type="text/css" />

    <link href="http://fonts.googleapis.com/css?family=Source+Sans+Pro" rel="stylesheet" type="text/css">
    <link href="http://fonts.googleapis.com/css?family=Open+Sans" rel="stylesheet" type="text/css">
    <link href="http://fonts.googleapis.com/css?family=Palatino+Linotype" rel="stylesheet" type="text/css">
    <link href="http://fonts.googleapis.com/css?family=Abel" rel="stylesheet" type="text/css">
    <link href="http://fonts.googleapis.com/css?family=Open+Sans" rel="stylesheet" type="text/css">
	<link href='https://fonts.googleapis.com/css?family=Ubuntu&subset=latin,cyrillic-ext' rel='stylesheet' type='text/css'>
	<link href='https://fonts.googleapis.com/css?family=Fira+Sans&subset=latin,cyrillic-ext' rel='stylesheet' type='text/css'>

    <link href="<?php get_theme_url(); ?>/styles/custom.css" rel="stylesheet" type="text/css" />
    <?php get_header(); ?>
</head>
<body id="pageBody">

<div id="decorative2">
    <div class="container">

        <div class="divPanel topArea notop nobottom">
            <div class="row-fluid">
                <div class="span12">

                    <div id="divLogo" class="pull-left">
                        <a href="<?php get_site_url(); ?>" id="divSiteTitle"><img src="<?php get_theme_url(); ?>/images/logo.png"> <?php get_site_name(); ?> <br><span style="line-height: 0; font-size: 12px; float: left; margin-left: 50px; margin-top: -6px;"><?php get_component('logo_desc'); ?></span></a>
						<br />
                    </div>

                    <div id="divMenuRight" class="pull-right">
                    <div class="navbar">
                        <button type="button" class="btn btn-navbar-highlight btn-large btn-primary" data-toggle="collapse" data-target=".nav-collapse">
                            Навигация <span class="icon-chevron-down icon-white"></span>
                        </button>
                        <div class="nav-collapse collapse">
                            <ul class="nav nav-pills ddmenu">
                           
                            <?php get_i18n_navigation(return_page_slug()); ?>
                                <!-- <li class="dropdown active"><a href="#">О компании</a></li>
								<li class="dropdown"><a href="#">О продукции</a></li>
                                <li class="dropdown"><a href="#">Как мы работаем?</a></li>
                                <li class="dropdown"><a href="#">Партнеры</a></li>
                                <li class="dropdown"><a href="#">Услуги</a></li>
                                <li class="dropdown"><a href="#">Контакты</a></li> -->
                            </ul>
                        </div>
                    </div>
                    </div>

                </div>
            </div>
        </div>

    </div>
</div>

<div id="decorative1" style="position:relative">
    <div class="container">

        <div class="divPanel headerArea">
            <div class="row-fluid">
                <div class="span12">

                        <div id="headerSeparator"></div>

                        <div id="divHeaderText" class="page-content">
                            <div id="divHeaderLine1"><?php get_component('site_slogan'); ?></div><br />
                        </div>

                        <div id="headerSeparator2"></div>

                </div>
            </div>

        </div>

    </div>
</div>

<div id="contentOuterSeparator"></div>

<div class="container">

    <div class="divPanel page-content">

        <div class="row-fluid">

                <div class="span3" id="divMain" style="float: left;">

                    <?php get_component('block1'); ?>

                </div>
				<div class="span3" id="divMain" style="float: left;">

                    <?php get_component('block2'); ?>

                </div>
				<div class="span3" id="divMain" style="float: left;">

                    <?php get_component('block3'); ?>

                </div>
				<div class="span3" id="divMain" style="float: left;">

                    <?php get_component('block4'); ?>

                </div>

            </div>

    </div>
<hr>
</div>

<div id="footerOuterSeparator"></div>

<div id="divFooter" class="footerArea">

    <div class="container">

        <div class="divPanel">

            <div class="row-fluid">
                <div class="span4" id="footerArea1">
                
                    <?php get_component('company'); ?>

                </div>
                <div class="span4" id="footerArea3">

                    <?php get_component('inform'); ?>

                </div>
                <div class="span4" id="footerArea4">
                    
                    <?php get_component('contacts'); ?>

                </div>
            </div>

            <br /><br />
            <div class="row-fluid">
                <div class="span12">
                    <p class="copyright">
                        Copyright © 2016. СтройТоргКомплект
                    </p>
                </div>
            </div>
            <br />

        </div>

    </div>
    
</div>

<script src="scripts/jquery.min.js" type="text/javascript"></script> 
<script src="scripts/bootstrap/js/bootstrap.min.js" type="text/javascript"></script>
<script src="scripts/default.js" type="text/javascript"></script>


<script src="scripts/carousel/jquery.carouFredSel-6.2.0-packed.js" type="text/javascript"></script><script type="text/javascript">$('#list_photos').carouFredSel({ responsive: true, width: '100%', scroll: 2, items: {width: 320,visible: {min: 2, max: 6}} });</script>


</body>
</html>