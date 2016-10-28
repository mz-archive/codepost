<?php

// register plugin
$thisfile = basename(__FILE__, ".php");
register_plugin(
	$thisfile,
	'News Manager Title',
	'0.2',
	'Carlos Navarro',
	'http://www.cyberiada.org/cnb/',
	'Replace/update GS page title with News Manager post title'
);

/****
 you can edit the following settings, or else copy them to your site's gsconfig.php file
****/

# Insert post title into/instead of page title. 1 = before, 2 = after, 0 = replace. Default 1.
#define("NMTPOSITION",1);

# Text to be used as separator between page title and post title. Default " - "
#define("NMTSEPARATOR"," - ");


/**** DO NOT EDIT PAST HERE ****/

add_action('index-pretemplate','nmt_set_gstitle');
add_action('theme-header','nmt_restore_gstitle');

function nmt_return_title() {
  if (function_exists('nm_post_title')) {
    $nmtitle = nm_post_title('','',false);
  } else {
    global $id, $NMPAGEURL;
    $nmtitle = false;
    if (isset($_GET['post']) && $id == $NMPAGEURL) {
      $file = NMPOSTPATH . $_GET['post'] . '.xml';
      if (dirname(realpath($file)) == realpath(NMPOSTPATH)) { // no path traversal
        $post = @getXML($file);
        if (!empty($post) && $post->private != 'Y') {
          $nmtitle = stripslashes($post->title);
        }	
      }
    }
  }
	return $nmtitle;
}

function nmt_set_gstitle() {
	global $title, $id;
	global $nmt_gstitle;
	global $NMPAGEURL;
	if (isset($_GET['post']) && $id == $NMPAGEURL) {
		$nmt_gstitle = $title; // saves the original title
		$nmtitle = nmt_return_title();
		if ($nmtitle) {
			$position = defined('NMTPOSITION') ? NMTPOSITION : 1;
			$separator = defined('NMTSEPARATOR') ? NMTSEPARATOR : ' - ';
			if ($position == 0)
				$title = $nmtitle;
			elseif ($position == 2)
				$title = $title.$separator.$nmtitle;
			else
				$title = $nmtitle.$separator.$title;
		}
	}
}

function nmt_restore_gstitle() {
	global $title, $id;
	global $nmt_gstitle;
	global $NMPAGEURL;
	if (isset($_GET['post']) && $id == $NMPAGEURL) {
		$title = $nmt_gstitle; // restores original title for the rest of the page
	}
}

// end of file