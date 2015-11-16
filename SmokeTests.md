# Introduction #

These are a basic suite of manual tests to QA the site before live deployment.

# Not logged in #

## Homepage ##

Homepage should show expected content.

Menus should be as expected.

Site email should be shown.

## Online Shop ##

Basket should be shown

Top level categories should be shown (if present)

Hovering on top level categories should show second level categories (if present)

## Basket ##

'Your basket is empty' should be shown.

## Category ##

Click on category. Products and sub categories should be shown.

# Log in as administrator #

http://

&lt;hostname&gt;

/shop/Login

Enter admin username: admin@sutekishop.co.uk password: admin

## Add a category ##

Click 'categories'

Click 'new category'
> Name: category1, Parent category: - Root, Active: checked

Click 'Submit Query'

category1 should appear both in the left hand category area and in the main category admin page that should now be shown.

Create a second cagtegory as above but named category2.

## Move a category ##

Click the green 'up arrow' next to category2. category2 should now come before category1 on both the left hand category menu and in the main category page.

Move category1 down again by clicking the down arrow.

## Edit a category ##

On the main category page, click 'Edit' next to category1.

Change the name category1 to category1x.

Click 'Submit Query'

Note changed name in both menu and main page.

## De-activate a category ##

Click 'Edit' next to category1 on the main category page.

Uncheck 'Active'.

Click 'Submit Query'.

Note red cross next to category1.

== Create a sub-category

Click 'New Category' on main category page.

Enter:
> Name: category1 sub1, Parent Category: category1x, Active: checked

Click 'Submit Query'

Note new sub category on both left category menu and on main page.

## Create a Product ##

Click category1 -> category1 sub1 on left category menu. Category page appears.

Click 'New Product'. Product form appears.

Enter:
> Name: soap
> Category: 

&lt;unchanged&gt;


> Weight: 10
> Price: 12.34
> Active: checked
> Description: A bar of soapy soap.
> Sizes: <one in each box> S M L
> Photos: click the first browse button, find a suitable jpg file to upload.

Click 'Save Changes'

The category page should appear with the new 'soap' product. Click on the soap product and confirm details.

## Edit a Product ##

Click 'Edit' on the soap product page. The product edit page appears.

Change the price to 14.40
Enter a new size: XL
Browse to another photo.

Click 'Save Changes'

Click on 'soap' and confirm changes.