* {
  box-sizing: border-box;
}

body {
  margin: 0;
  padding: 0;
}

html,
body {
  overflow-x: hidden;
}

input:focus,
textarea:focus,
button:focus {
  outline: none;
  box-shadow: none;
}

.btn-primary:focus {
  box-shadow: none !important;
}

a {
  color: inherit;
  text-decoration: none;
}

h1,
h2,
h3,
h4,
h5,
h6,
p {
  margin-bottom: 0;
}

.img-responsive {
  width: 100%;
}

img {
  width: 100%;
}

ul {
  list-style: none;
  padding: 0;
  margin: 0;
}

/*### Colors ###*/
/*--### Font Family ###--*/
h1,
h2,
h3,
h4,
h5,
h6 {
  font-family: "League Spartan", sans-serif;
  font-weight: 600;
}

p,
a {
  font-family: "League Spartan", sans-serif;
}

.container-fluid {
  padding: 0 5%;
}

h1,
h2,
h3 {
  line-height: 1;
  text-transform: uppercase;
  font-weight: 700;
  background-image: linear-gradient(135deg, #ac8c4f 0%, #f4e296 30%, #ac8c4f 50%, #ac8c4f 0%, #f4e296 80%, #ac8c4f 100%);
  background-size: 100%;
  background-repeat: repeat;
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

h1 {
  font-size: 88px;
}

h2 {
  font-size: 65px;
  margin-bottom: 15px;
}

.button .btn {
  background-image: linear-gradient(135deg, #ac8c4f 10%, #f4e296 100%);
  display: flex;
  width: fit-content;
  justify-content: center;
  align-items: center;
  padding: 19px 35px;
  border-radius: 80px;
  font-size: 20px;
  text-transform: uppercase;
  font-weight: 600;
  border: 1px solid #af9057;
  transition: 0.3s all ease;
}
.button .btn:hover {
  background: transparent;
  color: #fff;
  border: 1px solid;
  margin-left: 12px;
}
.button .btn-2 {
  background: transparent;
  color: #fff;
  border: 1px solid;
}
.button .btn-2:hover {
  background-image: linear-gradient(135deg, #ac8c4f 10%, #f4e296 100%);
  border: 1px solid #af9057;
}

section {
  padding: 5% 0;
}

p {
  font-size: 22px;
  color: rgba(255, 255, 255, 0.6);
  font-weight: 300;
  margin-bottom: 25px;
}

a:after {
  content: "";
  position: absolute;
  width: 0;
  height: 2px;
  display: block;
  margin-top: 0px;
  left: 0%;
  transition: width 0.3s ease;
}

a:hover:after {
  width: 100%;
  left: 0%;
}

.page-header {
  background: linear-gradient(0deg, rgb(0, 0, 0), rgba(0, 0, 0, 0.7)), url(../img/header-img.jpg);
  background-position: center;
}
.page-header .container-fluid .heading {
  text-align: center;
  padding-top: 115px;
}

.cursor {
  width: 50px;
  height: 50px;
  border-radius: 100%;
  border: 1px solid #fff;
  transition: all 200ms ease-out;
  position: fixed;
  pointer-events: none;
  left: 0;
  top: 0;
  z-index: 8;
  transform: translate(calc(-50% + 15px), -50%);
}

.cursor2 {
  width: 20px;
  height: 20px;
  border-radius: 100%;
  background-color: #fff;
  opacity: 0.3;
  position: fixed;
  transform: translate(-50%, -50%);
  pointer-events: none;
  z-index: 7;
  transition: width 0.3s, height 0.3s, opacity 0.3s;
}

.hover {
  background-color: #ac8c4f;
  opacity: 0.5;
}

.cursorinnerhover {
  width: 50px;
  height: 50px;
  opacity: 0.5;
}

header {
  background-color: rgba(0, 0, 0, 0.28);
  padding: 0px 0;
  backdrop-filter: blur(13px);
  position: fixed;
  top: 0;
  border-bottom: 1px solid rgba(255, 255, 255, 0.1019607843);
  width: 100%;
  z-index: 5;
}
header .navbar .logo img {
  width: 300px;
}
header .navbar .navbar-collapse {
  justify-content: end;
}
header .navbar .navbar-collapse ul li a {
  font-size: 19px;
  margin: 0 10px;
  padding: 40px 22px;
  background: linear-gradient(#ffffff 0 0) no-repeat var(--p, 200%) 100%/200% var(--p, 0.08em);
  transition: 0.3s var(--t, 0s), background-position 0.3s calc(0.3s - var(--t, 0s));
}
header .navbar .navbar-collapse ul li a:hover {
  --p: 100%;
  --t: 0.3s;
  color: #000 !important;
}

.menu-btn:hover {
  color: #fff;
}

.banner-section {
  background: linear-gradient(0deg, rgb(0, 0, 0), rgba(0, 0, 0, 0.7)), url(../img/Banner-image.jpg);
  padding-bottom: 0px;
}
.banner-section .overlay {
  background: url(../img/banner-background.png);
  padding-top: 220px;
}
.banner-section .overlay .container-fluid .row .column-1 {
  padding-top: 60px;
}
.banner-section .overlay .container-fluid .row .column-2 .image {
  margin-top: -140px;
}
.banner-section .overlay .container-fluid .row .column .content h1 {
  font-size: 88px;
}
.banner-section .overlay .container-fluid .row .column .content h3 {
  text-transform: uppercase;
  font-weight: 600;
  background-image: linear-gradient(135deg, #f7f7f7 0%, #bfbfbf 30%, #f7f7f7 50%, #bfbfbf 0%, #f7f7f7 80%, #bfbfbf 100%);
  background-size: 100%;
  background-repeat: repeat;
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
  font-size: 66px;
  margin-top: -20px;
  margin-bottom: 40px;
}

.container-2 {
  overflow: hidden;
  background: #000;
  cursor: ew-resize;
  white-space: nowrap;
  margin: 0;
  max-width: 100%;
}

.title {
  font: bold normal 12vw/1.2 "Montserrat", sans-serif;
  position: relative;
  color: #fff;
  display: inline-block;
  margin: 0;
  padding: 0 15%;
  will-change: transform;
}
.title img {
  width: 1080px;
  margin-top: -90px;
}

.video-section {
  background: #000;
}
.video-section .container-fluid .row {
  text-align: center;
}
.video-section .container-fluid .row .heading {
  margin-bottom: 30px;
}
.video-section .container-fluid .row .video {
  width: 60%;
  margin: 0 auto;
  margin-bottom: 40px;
  position: relative;
}
.video-section .container-fluid .row .video:hover img {
  opacity: 0.2;
}
.video-section .container-fluid .row .video:hover .icon {
  opacity: 1;
}
.video-section .container-fluid .row .video .icon {
  position: absolute;
  top: 50%;
  left: 50%;
  opacity: 0;
  transition: all 0.5s;
}
.video-section .container-fluid .row .video .icon i {
  font-size: 110px;
  background-image: linear-gradient(135deg, #ac8c4f 0%, #f4e296 30%, #ac8c4f 50%, #ac8c4f 0%, #f4e296 80%, #ac8c4f 100%);
  background-size: 100%;
  background-repeat: repeat;
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}
.video-section .container-fluid .row .video img {
  border-radius: 20px;
  box-shadow: 0px 0px 54px 3px rgba(182, 153, 94, 0.2117647059);
  border: 1px solid rgba(179, 149, 91, 0.4392156863);
  transition: all 0.3s;
}
.video-section .container-fluid .row .body-content {
  width: 60%;
  margin: 0 auto;
}
.video-section .container-fluid .row .body-content .button a {
  margin: 0 auto;
}

.img-txt-section {
  background-color: #000;
}
.img-txt-section .container-fluid .row .content {
  padding: 0 30px;
}
.img-txt-section .container-fluid .row .image img {
  border-radius: 22px;
}

.Amazon-Fba {
  background-color: #000;
}
.Amazon-Fba .roundborder {
  position: relative;
  height: 200px;
  width: 200px;
  border-radius: 100px;
  word-wrap: break-word;
  float: none;
  margin: 0 auto;
  background: #000;
  transition: all 0.5s;
}
.Amazon-Fba .roundborder:hover {
  filter: invert(1);
}
.Amazon-Fba .roundborder .roundcontent {
  position: absolute;
  height: 200px;
  width: 200px;
  border: 2px dashed rgb(255, 255, 255);
  border-radius: 100px;
  -webkit-transition-duration: 0.8s;
  -moz-transition-duration: 0.8s;
  -o-transition-duration: 0.8s;
  transition-duration: 0.8s;
  -webkit-animation: slideDash 10s infinite linear;
  animation: slideDash 10s infinite linear;
  -webkit-backface-visibility: hidden;
}
.Amazon-Fba .roundborder .roundborder .text {
  position: absolute;
  height: 200px;
  width: 200px;
  top: 14px;
  left: 14px;
  padding: 5px;
  word-wrap: break-word;
  box-sizing: border-box;
}
@-webkit-keyframes slideDash {
  to {
    -webkit-transform: rotate(360deg);
  }
}
.Amazon-Fba .roundborder .icon {
  width: 64px;
  margin: 0 auto;
}
.Amazon-Fba .roundborder .icon img {
  margin-top: 40px;
}
.Amazon-Fba .roundborder .text {
  text-align: center;
}

.product-research {
  background-color: #050505;
}
.product-research .container-fluid .heading {
  text-align: center;
  width: 80%;
  margin: 0 auto;
  margin-bottom: 80px;
}
.product-research .container-fluid .row {
  margin-bottom: 40px;
}
.product-research .container-fluid .row .main-column {
  padding: 0 22px;
}
.product-research .container-fluid .row .image {
  margin-bottom: 30px;
}
.product-research .container-fluid .row .image img {
  border-radius: 25px;
}
.product-research .container-fluid .row .content {
  padding: 0 30px;
}
.product-research .container-fluid .row .content p {
  margin-bottom: 20px;
  font-size: 20px;
}
.product-research .container-fluid .row .content h5 {
  font-size: 34px;
  color: rgba(255, 255, 255, 0.7098039216);
  font-weight: 500;
  line-height: 1;
  margin-bottom: 11px;
}
.product-research .container-fluid .row .content a {
  font-size: 22px;
  font-weight: 200;
  color: rgba(255, 255, 255, 0.6);
  border-bottom: 1px solid #b4965c;
}

.cta-section {
  background: url(../img/Bg\ Call\ to\ Action.png);
  background-size: cover;
  background-position: bottom;
}
.cta-section .container-fluid .heading {
  width: 80%;
  margin: 0 auto;
  text-align: center;
  margin-bottom: 40px;
}
.cta-section .container-fluid .row {
  width: 74%;
  margin: 0 auto;
  justify-content: space-evenly;
}
.cta-section .container-fluid .row .column-1 {
  background-color: rgba(0, 0, 0, 0.168627451);
}
.cta-section .container-fluid .row .column-2 {
  background-image: linear-gradient(135deg, #ac8c4f 0%, #f4e296 30%, #ac8c4f 50%, #ac8c4f 0%, #f4e296 80%, #ac8c4f 100%);
}
.cta-section .container-fluid .row .column {
  padding: 42px 40px;
  border-radius: 18px;
  text-align: center;
  width: 47%;
  border: 1px solid rgba(255, 255, 255, 0.1215686275);
  background: rgba(0, 0, 0, 0.3019607843);
  backdrop-filter: blur(114px);
}
.cta-section .container-fluid .row .column .icon {
  margin-bottom: 12px;
  background: rgba(255, 255, 255, 0.0588235294);
  display: flex;
  width: fit-content;
  border-radius: 80px;
  padding: 10px 30px;
  margin-bottom: 80px;
}
.cta-section .container-fluid .row .column .icon img {
  width: 21px;
  height: 20px;
  filter: invert(1);
  opacity: 0.7;
  margin-top: 3px;
}
.cta-section .container-fluid .row .column .icon h6 {
  font-size: 20px;
  font-weight: 400;
  margin-left: 11px;
  margin-top: 3px;
  color: rgba(255, 255, 255, 0.6);
}
.cta-section .container-fluid .row .column .icon i {
  font-size: 25px;
  color: rgba(255, 255, 255, 0.6);
}
.cta-section .container-fluid .row .column .content {
  text-align: left;
}
.cta-section .container-fluid .row .column .content h4 {
  font-size: 38px;
  font-weight: 600;
  color: rgba(255, 255, 255, 0.6);
  margin-bottom: 12px;
}
.cta-section .container-fluid .row .column .content p {
  color: #000;
}

.about-1 {
  padding-bottom: 0;
}

.img-txt-section .icon-text p {
  font-size: 26px;
  margin-bottom: 15px;
}
.img-txt-section .icon-text p img {
  width: 50px;
  margin-right: 14px;
}

.about-2 {
  padding-bottom: 5%;
}

.about-3 {
  background-color: black;
}
.about-3 .heading {
  text-align: center;
}
.about-3 .inner-content-row {
  padding: 35px 35px !important;
}
.about-3 .inner-content-row .icon {
  margin-bottom: 15px !important;
}
.about-3 .inner-content-row .icon img {
  width: 80px;
  margin-bottom: 15px;
}
.about-3 .inner-content-row .content {
  text-align: left;
}
.about-3 .inner-content-row .content h5 {
  font-size: 30px;
  color: rgba(255, 255, 255, 0.7098039216);
  font-weight: 500;
  line-height: 1.3;
  margin-bottom: 11px;
}
.about-3 .inner-content-row .content a {
  font-size: 22px;
  font-weight: 200;
  color: rgba(255, 255, 255, 0.6);
  border-bottom: 1px solid #b4965c;
}

.services-section {
  background: #000;
}
.services-section:nth-child(even) .row {
  flex-direction: row-reverse;
}
.services-section .container-fluid .row .content .points-text p {
  background: #050505;
  padding: 21px 29px;
  border-radius: 12px;
  border: 1px solid rgba(255, 255, 255, 0.031372549);
  transition: all 0.3s;
}
.services-section .container-fluid .row .content .points-text p:hover {
  margin-left: 20px;
}
.services-section .container-fluid .row .image {
  width: 85%;
  margin: 0 auto;
}

.element-services-section {
  background: #000;
}
.element-services-section .container-fluid .heading {
  text-align: center;
}
.element-services-section .container-fluid .row {
  padding: 25px 0;
}
.element-services-section .container-fluid .row .content {
  background: #0d0d0d;
  padding: 34px 32px;
  border-radius: 20px;
  border: 1px solid #000;
  transition: all 0.3s;
}
.element-services-section .container-fluid .row .content:hover {
  background: #050505;
  border: 1px solid rgba(255, 255, 255, 0.2784313725);
}
.element-services-section .container-fluid .row .content .image {
  width: 90px;
  margin-bottom: 20px;
}
.element-services-section .container-fluid .row .content .text h4 {
  color: rgba(255, 255, 255, 0.6);
}

.testiomoinals-section {
  background: #000;
}
.testiomoinals-section .container-fluid .heading {
  text-align: center;
  margin-bottom: 75px;
}
.testiomoinals-section .container-fluid .row {
  margin-top: 75px;
}
.testiomoinals-section .container-fluid .row .content {
  background-color: #050505;
  padding: 30px 44px 5px 44px;
  border-radius: 18px;
}
.testiomoinals-section .container-fluid .row .content .image {
  width: 75px;
  margin-bottom: 15px;
  margin-top: -50px;
}
.testiomoinals-section .container-fluid .row .content .image img {
  border-radius: 50px;
}
.testiomoinals-section .container-fluid .row .content .body {
  color: rgba(255, 255, 255, 0.6);
}
.testiomoinals-section .container-fluid .row .content .body .rating {
  background-image: linear-gradient(135deg, #ac8c4f 0%, #f4e296 30%, #ac8c4f 50%, #ac8c4f 0%, #f4e296 80%, #ac8c4f 100%);
  background-size: 100%;
  background-repeat: repeat;
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
  margin-top: 20px;
  margin-bottom: 10px;
}
.testiomoinals-section .container-fluid .row .content .body .country {
  padding-top: 15px;
}
.testiomoinals-section .container-fluid .row .content .body .country p {
  font-size: 20px;
}
.testiomoinals-section .container-fluid .row .content .body .country p img {
  width: 28px;
  margin-right: 10px;
}

/*### Blog ###*/
.blog-posts {
  background: #000;
}
.blog-posts .container-fluid {
  /*### Row ###*/
}
.blog-posts .container-fluid .heading {
  text-align: center;
  margin-bottom: 45px;
}
.blog-posts .container-fluid .row {
  width: 80%;
  margin: 0 auto;
}
@media (max-width: 1200px) {
  .blog-posts .container-fluid .row {
    width: 100%;
  }
}
.blog-posts .container-fluid .row .post-grid {
  background: #050505;
  /*### All-Posts ###*/
}
@media (max-width: 767px) {
  .blog-posts .container-fluid .row .post-grid {
    margin-bottom: 40px;
  }
}
.blog-posts .container-fluid .row .post-grid .content {
  padding: 34px 42px;
}
.blog-posts .container-fluid .row .post-grid .content .publish-date {
  font-size: 14px;
  margin-bottom: 14px;
}
.blog-posts .container-fluid .row .post-grid .content h3 {
  font-weight: 700;
  margin-bottom: 14px;
}
.blog-posts .container-fluid .row .post-grid .content p {
  font-size: 16px;
  margin-bottom: 26px;
}
.blog-posts .container-fluid .row .post-grid .content a {
  color: #ac8c51;
  border-bottom: 1px solid;
  font-size: 18px;
  font-weight: 700;
  transition: all 0.3s;
}
.blog-posts .container-fluid .row .post-grid .content a:hover {
  opacity: 0.8;
}

/*### Blog-End ###*/
.blog-page {
  background: #000;
}
.blog-page .container-fluid .post-row {
  width: 85%;
  margin: 0 auto;
  background: #050505;
  padding: 65px;
}
@media (max-width: 991px) {
  .blog-page .container-fluid .post-row {
    padding: 35px;
    width: 100%;
  }
}
.blog-page .container-fluid .post-row .post-content .image {
  margin-bottom: 25px;
}
.blog-page .container-fluid .post-row .post-content .image img {
  box-shadow: 0px 30px 60px 0px rgba(0, 0, 0, 0.1);
}
.blog-page .container-fluid .post-row .post-content .body {
  padding: 19px 29px;
}
@media (max-width: 991px) {
  .blog-page .container-fluid .post-row .post-content .body {
    padding: 19px 0px;
  }
}
.blog-page .container-fluid .post-row .post-content .body p {
  font-size: 22px;
  margin-bottom: 10px;
}
.blog-page .container-fluid .post-row .post-content .body .buttons .row {
  width: 250px;
  margin-top: 22px;
}
.blog-page .container-fluid .post-row .post-content .body .buttons .row a {
  font-size: 18px;
  transition: all 0.3s;
  color: rgba(255, 255, 255, 0.6);
}
.blog-page .container-fluid .post-row .post-content .body .buttons .row a:hover {
  color: black;
  opacity: 0.5;
  color: white;
}

/*### Contact ###*/
.contact {
  background: #000;
}
.contact .container-fluid {
  /*### Row ###*/
}
.contact .container-fluid .row {
  /*### Contact-form ###*/
}
.contact .container-fluid .row .contact-form {
  width: 65%;
  margin: 0 auto;
}
@media (max-width: 767px) {
  .contact .container-fluid .row .contact-form {
    width: 100%;
  }
}
.contact .container-fluid .row .contact-form .container {
  padding: 16px;
  /* Full-width input fields */
}
.contact .container-fluid .row .contact-form .container input[type=text],
.contact .container-fluid .row .contact-form .container input[type=password],
.contact .container-fluid .row .contact-form .container input[type=tel],
.contact .container-fluid .row .contact-form .container textarea {
  width: 100%;
  padding: 15px;
  margin: 5px 0 22px 0;
  display: inline-block;
  border: none;
  background: transparent !important;
  border-bottom: 1px solid rgba(255, 255, 255, 0.2117647059);
  color: rgb(212, 212, 212);
}
.contact .container-fluid .row .contact-form .container input[type=text]:focus,
.contact .container-fluid .row .contact-form .container input[type=password]:focus,
.contact .container-fluid .row .contact-form .container input[type=tel]:focus,
.contact .container-fluid .row .contact-form .container textarea {
  background-color: #ddd;
  outline: none;
  color: rgb(212, 212, 212);
}
.contact .container-fluid .row .contact-form .container .titles {
  text-align: center;
}
.contact .container-fluid .row .contact-form .container .titles p {
  margin-bottom: 0;
}
.contact .container-fluid .row .contact-form .container .button .btn {
  margin: 0 auto;
}

/*### Contact-End ###*/
footer {
  background: #050505;
}
footer .container-fluid .footer {
  border-bottom: 1px solid rgba(255, 255, 255, 0.1490196078);
  padding: 100px 0;
}
footer .container-fluid .footer p {
  font-size: 20px;
  margin-bottom: 2px;
}
footer .container-fluid .footer p a {
  transition: all 0.3s;
}
footer .container-fluid .footer p a:hover {
  color: white;
}
footer .container-fluid .footer-bottom {
  padding-top: 100px;
}
footer .container-fluid .footer-bottom .row {
  text-align: center;
}
footer .container-fluid .footer-bottom .row .follow-us {
  display: flex;
  justify-content: center;
  margin-bottom: 25px;
}
footer .container-fluid .footer-bottom .row .follow-us li {
  transition: all 0.3s;
}
footer .container-fluid .footer-bottom .row .follow-us li:hover {
  opacity: 0.5;
}
footer .container-fluid .footer-bottom .row .follow-us li a i {
  font-size: 22px;
  color: rgba(255, 255, 255, 0.6);
  border: 1px solid;
  width: 55px;
  height: 55px;
  padding: 16px;
  border-radius: 50px;
  margin-right: 15px;
}
footer .container-fluid .footer-bottom .row .copyright p {
  font-size: 18px;
}
footer .container-fluid .footer-bottom .row .copyright p a {
  transition: all 0.3s;
}
footer .container-fluid .footer-bottom .row .copyright p a:hover {
  color: white;
}

/*# sourceMappingURL=style.cs.map */
