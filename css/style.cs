@charset "UTF-8";
@import url("https://fonts.googleapis.com/css2?family=Work+Sans:wght@300&display=swap");
@import url(//fonts.googleapis.com/earlyaccess/notosanskr.css);
body {
  overflow-x: hidden;
}

a:link {
  color: inherit; /* 링크의 기본 색상을 상속받음 */
  text-decoration: none; /* 밑줄 제거 */
}

a:visited {
  color: inherit; /* 방문한 링크의 색상을 상속받음 */
}

.h {
  position: absolute;
  z-index: -99999;
  top: 0;
  left: 0;
}

header {
  width: 24.2%;
  height: 110px;
  display: flex;
  justify-content: center;
  align-items: center;
  text-align: center;
  background: #171717;
  position: fixed;
  top: 0;
  right: 0;
  z-index: 999;
}
header .rightBar {
  width: 24.2%;
  margin-top: 110px;
  height: 100vh;
  background: #010001;
  position: fixed;
  top: 0;
  right: 0;
  z-index: 1;
  display: none;
}
header .rightBar.rgt {
  width: 24.2%;
  background: #010001;
  position: fixed;
  top: 0;
  right: 0;
  display: block;
  animation: moveR 0.5s linear;
  animation-fill-mode: backwards;
  animation-delay: 0s;
}
@keyframes moveR {
  from {
    height: 0%;
  }
  to {
    height: 100%;
  }
}
header .leftBar {
  height: 100%;
  width: 50.4%;
  background: #010001;
  position: fixed;
  display: flex;
  justify-content: center;
  align-items: center;
  left: 0;
  top: 0;
  animation: move 0.5s linear;
  animation-fill-mode: backwards;
  animation-delay: 0s;
  display: none;
  overflow: hidden;
}
header .leftBar .leftBarWrap {
  width: 100%;
}
header .leftBar .leftBarWrap .leftBarTit {
  height: 20px;
  text-align: left;
  display: flex;
  justify-content: end;
  flex-direction: column;
  padding: 0px 10vw 0px;
}
header .leftBar .leftBarWrap .leftBarTit h2 {
  font: 70px/1 "Noto Sans KR";
  color: #e9e9e9;
  animation: appear 0.5s linear;
  animation-fill-mode: backwards;
  animation-delay: 0.5s;
  opacity: 1;
}
@keyframes appear {
  from {
    opacity: 0;
  }
  to {
    opacity: 1;
  }
}
header .leftBar .leftBarWrap .leftBarList {
  width: 100%;
  height: 300px;
  padding: 60px 0px 60px;
  text-align: left;
  padding: 60px 10vw 0px;
}
header .leftBar .leftBarWrap .leftBarList .circle {
  position: absolute;
  top: 0;
  left: 0;
  width: 150px;
  height: 150px;
  border-radius: 50%;
  background-color: #f9f9f9;
  transform: translate(-50%, -50%);
  mix-blend-mode: difference;
}
header .leftBar .leftBarWrap .leftBarList .listLine {
  width: 100px;
  height: 1px;
  background: #e9e9e9;
  margin-bottom: 30px;
  animation: appear 0.5s linear;
  animation-fill-mode: backwards;
  animation-delay: 0.5s;
  opacity: 1;
}
@keyframes appear {
  from {
    opacity: 0;
  }
  to {
    opacity: 1;
  }
}
header .leftBar .leftBarWrap .leftBarList ul {
  cursor: pointer;
}
header .leftBar .leftBarWrap .leftBarList ul:nth-of-type(2) {
  display: flex;
  width: 100%;
  flex-wrap: wrap;
  float: left;
  margin-top: 30px;
  gap: 0px;
  font: 24px/35px "Noto Sans KR";
  color: #969696;
  cursor: pointer;
}
header .leftBar .leftBarWrap .leftBarList ul:nth-of-type(2) li:nth-of-type(1):nth-of-type(1):after {
  content: "|";
  padding-left: 15px;
  padding-right: 15px;
}
header .leftBar .leftBarWrap .leftBarList ul:nth-of-type(3) {
  display: flex;
  float: left;
  margin-top: 20px;
  gap: 30px;
  font: 24px/35px "Noto Sans KR";
  color: #969696;
  cursor: pointer;
}
header .leftBar .leftBarWrap .leftBarList ul li {
  font: 24px/35px "Noto Sans KR";
  color: #969696;
  animation: appear 0.5s linear;
  animation-fill-mode: backwards;
  animation-delay: 0.5s;
  opacity: 1;
}
header .leftBar .leftBarWrap .leftBarList ul li a:visited {
  color: #969696;
  cursor: pointer;
}
header .leftBar .leftBarWrap .leftBarList ul li a:visited a:link {
  color: #969696;
  cursor: pointer;
}
header .leftBar .leftBarWrap .leftBarList ul li a:visited a:visited {
  color: #969696;
  cursor: pointer;
}
header .leftBar .leftBarWrap .leftBarList ul li a:visited a:active {
  color: #969696;
  cursor: pointer;
}
header .leftBar .leftBarWrap .leftBarList ul li a:visited a:hover {
  color: #969696;
  cursor: pointer;
}
@keyframes appear {
  from {
    opacity: 0;
  }
  to {
    opacity: 1;
  }
}
header .leftBar.lft {
  background: #010001;
  position: fixed;
  left: 0;
  top: 0;
  display: block;
  animation: moveL 0.5s linear;
  animation-fill-mode: backwards;
  animation-delay: 0s;
  display: flex;
}
@keyframes moveL {
  from {
    width: 0%;
  }
  to {
    width: 50.5%;
  }
}
header .menu {
  flex: 1.5;
  font: 35px/1 "Noto Sans KR";
  color: #e9e9e9;
  cursor: pointer;
}
header .menu .fa-bars-staggered {
  display: block;
}
header .menu .fa-xmark {
  display: none;
  animation: roateCloseBtn 0.5s ease-in;
  animation-fill-mode: backwards;
  animation-duration: 0.5s;
}
@keyframes roateCloseBtn {
  from {
    transform: rotate(0deg);
  }
  to {
    transform: rotate(720deg);
  }
}
header .logo {
  flex: 5;
  cursor: pointer;
}
header .logo p {
  font: bold 35px/1 "Noto Sans KR";
  color: #e9e9e9;
}
header .logo p a:visited {
  color: #e9e9e9;
  cursor: pointer;
}

@media screen and (max-width: 1023px) {
  header {
    width: 37%;
  }
  header .rightBar {
    width: 37%;
  }
  header .rightBar.rgt {
    width: 37%;
  }
  header .leftBar {
    height: 100%;
    width: 50.4%;
    background: #010001;
    position: fixed;
    display: flex;
    justify-content: center;
    align-items: center;
    left: 0;
    top: 0;
    animation: move 0.5s linear;
    animation-fill-mode: backwards;
    animation-delay: 0s;
    display: none;
    overflow: hidden;
  }
  header .leftBar .leftBarWrap {
    width: 100%;
  }
  header .leftBar .leftBarWrap .leftBarTit {
    height: 20px;
    text-align: left;
    display: flex;
    justify-content: end;
    flex-direction: column;
    padding: 0px 10vw 0px;
  }
  header .leftBar .leftBarWrap .leftBarTit h2 {
    font: 70px/1 "Noto Sans KR";
    color: #e9e9e9;
    animation: appear 0.5s linear;
    animation-fill-mode: backwards;
    animation-delay: 0.5s;
    opacity: 1;
  }
  @keyframes appear {
    from {
      opacity: 0;
    }
    to {
      opacity: 1;
    }
  }
  header .leftBar .leftBarWrap .leftBarList {
    width: 100%;
    height: 300px;
    padding: 60px 0px 60px;
    text-align: left;
    padding: 60px 10vw 0px;
  }
  header .leftBar .leftBarWrap .leftBarList .circle {
    position: absolute;
    top: 0;
    left: 0;
    width: 150px;
    height: 150px;
    border-radius: 50%;
    background-color: #f9f9f9;
    transform: translate(-50%, -50%);
    mix-blend-mode: difference;
  }
  header .leftBar .leftBarWrap .leftBarList .listLine {
    width: 100px;
    height: 1px;
    background: #e9e9e9;
    margin-bottom: 30px;
    animation: appear 0.5s linear;
    animation-fill-mode: backwards;
    animation-delay: 0.5s;
    opacity: 1;
  }
  @keyframes appear {
    from {
      opacity: 0;
    }
    to {
      opacity: 1;
    }
  }
  header .leftBar .leftBarWrap .leftBarList li {
    font: 24px/35px "Noto Sans KR";
    color: #969696;
    animation: appear 0.5s linear;
    animation-fill-mode: backwards;
    animation-delay: 0.5s;
    opacity: 1;
  }
  @keyframes appear {
    from {
      opacity: 0;
    }
    to {
      opacity: 1;
    }
  }
  header .leftBar.lft {
    background: #010001;
    position: fixed;
    left: 0;
    top: 0;
    display: block;
    animation: moveL 0.5s linear;
    animation-fill-mode: backwards;
    animation-delay: 0s;
    display: flex;
  }
  @keyframes moveL {
    from {
      width: 0%;
    }
    to {
      width: 50.5%;
    }
  }
  header .menu {
    flex: 1.5;
    font: 35px/1 "Noto Sans KR";
    color: #e9e9e9;
    cursor: pointer;
  }
  header .menu .fa-bars-staggered {
    display: block;
  }
  header .menu .fa-xmark {
    display: none;
    animation: roateCloseBtn 0.5s ease-in;
    animation-fill-mode: backwards;
    animation-duration: 0.5s;
  }
  @keyframes roateCloseBtn {
    from {
      transform: rotate(0deg);
    }
    to {
      transform: rotate(720deg);
    }
  }
  header .logo {
    flex: 5;
    cursor: pointer;
  }
  header .logo p {
    font: 35px/1 "Noto Sans KR";
    color: #e9e9e9;
  }
}
@media screen and (max-width: 639px) {
  header {
    width: 50%;
    height: 95px;
  }
  header .rightBar {
    width: 50%;
  }
  header .rightBar.rgt {
    width: 49.6%;
    margin-top: 95px;
  }
  header .leftBar {
    height: 100%;
    width: 50.4%;
    background: #010001;
    position: fixed;
    display: flex;
    justify-content: center;
    align-items: center;
    left: 0;
    top: 0;
    animation: move 0.5s linear;
    animation-fill-mode: backwards;
    animation-delay: 0s;
    display: none;
    overflow: hidden;
  }
  header .leftBar .leftBarWrap {
    width: 100%;
  }
  header .leftBar .leftBarWrap .leftBarTit {
    height: 20px;
    text-align: left;
    display: flex;
    justify-content: end;
    flex-direction: column;
    padding: 0px 5vw 0px;
  }
  header .leftBar .leftBarWrap .leftBarTit h2 {
    font: 44px/1 "Noto Sans KR";
    color: #e9e9e9;
    animation: appear 0.5s linear;
    animation-fill-mode: backwards;
    animation-delay: 0.5s;
    opacity: 1;
  }
  @keyframes appear {
    from {
      opacity: 0;
    }
    to {
      opacity: 1;
    }
  }
  header .leftBar .leftBarWrap .leftBarList {
    width: 100%;
    height: 300px;
    padding: 60px 0px 60px;
    text-align: left;
    padding: 60px 5vw 0px;
  }
  header .leftBar .leftBarWrap .leftBarList .circle {
    position: absolute;
    top: 0;
    left: 0;
    width: 150px;
    height: 150px;
    border-radius: 50%;
    background-color: #f9f9f9;
    transform: translate(-50%, -50%);
    mix-blend-mode: difference;
  }
  header .leftBar .leftBarWrap .leftBarList .listLine {
    width: 100px;
    height: 1px;
    background: #e9e9e9;
    margin-bottom: 30px;
    animation: appear 0.5s linear;
    animation-fill-mode: backwards;
    animation-delay: 0.5s;
    opacity: 1;
  }
  @keyframes appear {
    from {
      opacity: 0;
    }
    to {
      opacity: 1;
    }
  }
  header .leftBar .leftBarWrap .leftBarList li {
    font: 24px/35px "Noto Sans KR";
    color: #969696;
    animation: appear 0.5s linear;
    animation-fill-mode: backwards;
    animation-delay: 0.5s;
    opacity: 1;
  }
  @keyframes appear {
    from {
      opacity: 0;
    }
    to {
      opacity: 1;
    }
  }
  header .leftBar.lft {
    background: #010001;
    position: fixed;
    left: 0;
    top: 0;
    display: block;
    animation: moveL 0.5s linear;
    animation-fill-mode: backwards;
    animation-delay: 0s;
    display: flex;
  }
  @keyframes moveL {
    from {
      width: 0%;
    }
    to {
      width: 50.5%;
    }
  }
  header .menu {
    flex: 1.5;
    font: 30px/1 "Noto Sans KR";
    color: #e9e9e9;
    cursor: pointer;
  }
  header .menu .fa-bars-staggered {
    display: block;
  }
  header .menu .fa-xmark {
    display: none;
    animation: roateCloseBtn 0.5s ease-in;
    animation-fill-mode: backwards;
    animation-duration: 0.5s;
  }
  @keyframes roateCloseBtn {
    from {
      transform: rotate(0deg);
    }
    to {
      transform: rotate(720deg);
    }
  }
  header .logo {
    flex: 5;
    cursor: pointer;
  }
  header .logo p {
    font: 30px/1 "Noto Sans KR";
    color: #e9e9e9;
  }
}
footer {
  width: 100vw;
  height: 461px;
  bottom: 0;
  position: relative;
  left: 0;
  right: 0;
}
footer img {
  padding-top: 0px;
  margin-bottom: 0;
  object-fit: cover;
  width: 100%;
  height: 100%;
}
footer .footerContainer {
  flex: 1;
  width: 100%;
  height: 300px;
  flex-direction: column;
  background: white;
  display: flex;
  flex-wrap: nowrap;
  justify-content: center;
  align-items: center;
  padding: 110px 1vw 0px;
}
footer .footerContainer li {
  font: 25px/1 "Noto Sans KR";
  color: #333;
  float: left;
  cursor: pointer;
}
footer .footerContainer li:after {
  content: "|";
  top: 50%;
  left: 100%;
  margin-left: 20px;
  margin-right: 20px;
}
footer .footerContainer li:nth-of-type(5):after {
  content: "";
  top: 50%;
  left: 100%;
  margin-left: 20px;
  margin-right: 20px;
}
footer .footerLeftCategory {
  flex: 1;
  padding-top: 70px;
  width: 100%;
  height: 100%;
  background: white;
  display: flex;
  flex-wrap: nowrap;
  justify-content: space-between;
  align-items: center;
}
footer .footerLeftCategory ul {
  float: left;
  margin-left: 10px;
  display: flex;
}
footer .footerLeftCategory ul:nth-of-type(1) li {
  font: 16px/1 "Noto Sans KR";
  color: #333;
}
footer .footerLeftCategory ul:nth-of-type(1) li:nth-of-type(1):after {
  content: "|";
  top: 50%;
  left: 100%;
  margin-left: 20px;
  margin-right: 20px;
}
footer .footerLeftCategory ul:nth-of-type(2) li {
  font: 16px/1 "Noto Sans KR";
  color: #333;
  margin-left: -100px;
}
footer .footerLeftCategory ul li {
  font: 16px/1 "Noto Sans KR";
  color: #333;
  cursor: pointer;
}
footer .footerLeftCategory ul li:after {
  content: "";
  top: 50%;
  left: 100%;
  margin-left: 20px;
  margin-right: 20px;
}

* {
  margin: 0px;
  padding: 0px;
  box-sizing: border-box;
}

li,
ul,
ol {
  list-style: none;
}

a {
  text-decoration: none;
}

.pop {
  width: 100%;
  height: 100vh;
  background: rgba(0, 0, 0, 0.9);
  position: fixed;
  top: 0;
  left: 0px;
  padding: 110px;
  z-index: 5;
  opacity: 0;
  transition: opacity 1s;
}
.pop.on {
  opacity: 1;
}
.pop .con {
  width: 100%;
  height: 100%;
}
.pop .con iframe,
.pop .con video,
.pop .con img {
  width: 100%;
  height: 100%;
  object-fit: cover;
  border: none;
}
.pop .close {
  font: 35px/1 "$ikeaFont";
  color: #eee;
  position: absolute;
  top: 30px;
  left: 50px;
  cursor: pointer;
}

#visual {
  width: 100vw;
  height: 100vh;
  background-image: url(../img/visual1.png);
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
}
#visual .visualWrap {
  width: 100%;
  height: 100%;
  display: grid;
  grid-template-columns: 1fr 1fr 1fr 1fr 1fr 1fr 2fr;
  grid-template-rows: 0.8fr 1.7fr 1.7fr 3fr;
  backdrop-filter: brightness(0.6);
}
#visual .visualWrap .bg {
  height: 100%;
  border: 1px solid rgba(59, 59, 59, 0.5);
  color: yellow;
}
#visual .visualWrap .bg:nth-of-type(2) {
  grid-column: span 3;
}
#visual .visualWrap .bg:nth-of-type(7) {
  grid-column: span 3;
}
#visual .visualWrap .bg:nth-of-type(8) {
  padding: 15px 1vw 0px;
  font: 18px/1 "Noto Sans KR";
  color: #e9e9e9;
  border: 1px solid #eee;
  cursor: pointer;
}
#visual .visualWrap .bg:nth-of-type(8).on {
  box-shadow: 0 0 50px 15px rgba(254, 194, 2, 0.45);
  background: #fec202;
  color: #171717;
  border: none;
}
#visual .visualWrap .bg:nth-of-type(9) {
  padding: 170px 1vw 15px;
  font: 18px/1 "Noto Sans KR";
  color: #e9e9e9;
  text-align: start;
}
#visual .visualWrap .bg:nth-of-type(11) {
  grid-row: span 2;
}
#visual .visualWrap .bg:nth-of-type(12) {
  grid-column: span 4;
  grid-row: span 4;
  padding: 60px 0vw 0px;
}
#visual .visualWrap .bg:nth-of-type(12) h1 {
  width: 100%;
  font: 30px/1 "Noto Sans KR";
  color: #cdcdcd;
  text-align: justify;
  word-break: break-all;
}
#visual .visualWrap .bg:nth-of-type(12) p {
  font: 18px/1 "Noto Sans KR";
  color: #969696;
  text-align: justify;
  word-break: break-all;
  margin-bottom: 20px;
}
#visual .visualWrap .bg:nth-of-type(13) {
  text-align: end;
  padding: 170px 1vw 15px;
  font: 18px/1 "Noto Sans KR";
  color: #e9e9e9;
  border: 1px solid #eee;
  cursor: pointer;
}
#visual .visualWrap .bg:nth-of-type(13).on {
  box-shadow: 0 0 50px 15px rgba(254, 194, 2, 0.45);
  background: #fec202;
  border: none;
  color: #171717;
  cursor: pointer;
}
#visual .visualWrap .bg:nth-of-type(14) {
  grid-row: span 2;
}

@media screen and (max-width: 1023px) {
  #visual {
    height: 100vh;
  }
  #visual .visualWrap {
    grid-template-columns: 0.6fr 0fr 0fr 1fr 1fr 1fr 0.6fr;
  }
  #visual .visualWrap .bg:nth-of-type(8) {
    padding: 20px 2vw 0px;
  }
  #visual .visualWrap .bg:nth-of-type(9) {
    padding: 170px 2vw 15px;
  }
  #visual .visualWrap .bg:nth-of-type(12) h1 {
    width: 90%;
    font: 28px/1 "Noto Sans KR";
  }
  #visual .visualWrap .bg:nth-of-type(13) {
    padding: 170px 2vw 15px;
  }
}
@media screen and (max-width: 639px) {
  #visual {
    height: 80vh;
  }
  #visual .visualWrap {
    grid-template-columns: 0.1fr 0fr 0fr 0fr 1fr 1fr 0.1fr;
    grid-template-rows: 7fr 1.5fr 1.5fr 3fr;
  }
  #visual .visualWrap .bg:nth-of-type(8) {
    padding: 10px 3vw 0px;
  }
  #visual .visualWrap .bg:nth-of-type(9) {
    padding: 170px 3vw 10px;
  }
  #visual .visualWrap .bg:nth-of-type(12) {
    grid-column: span 4;
    grid-row: span 4;
    padding: 60px 0vw 0px;
  }
  #visual .visualWrap .bg:nth-of-type(12) h1 {
    display: none;
  }
  #visual .visualWrap .bg:nth-of-type(12) p {
    display: none;
  }
  #visual .visualWrap .bg:nth-of-type(13) {
    padding: 170px 3vw 10px;
  }
}
#products {
  width: 100vw;
  height: 500px;
  background: #f9f9f9;
  display: flex;
  align-items: center;
  justify-content: center;
  padding: 96px 10vw 96px;
}
#products .productsContainer {
  width: 100%;
  height: 100%;
  display: flex;
  align-items: center;
  justify-content: center;
}
#products .productsContainer .productsTit {
  width: 100%;
  height: 100%;
  flex: 2;
  background: #f9f9f9;
  font: bold 70px/1 "Noto Sans KR";
  color: #333;
}
#products .productsContainer .productsSub {
  width: 74%;
  height: 100%;
  flex: 1;
  display: flex;
  flex-wrap: wrap;
  flex-direction: column;
  padding: 0px 0vw 0px;
}
#products .productsContainer .productsSub .slideContainer {
  width: 100%;
  overflow: hidden;
  display: flex;
  height: 50%;
  flex: 2.5;
  position: relative;
}
#products .productsContainer .productsSub .slideContainer .slideWrap {
  gap: 20px;
  display: flex;
  animation: moveRe 20s linear infinite;
  animation-delay: 0s;
  justify-content: center;
}
#products .productsContainer .productsSub .slideContainer .slideWrap .slideItem {
  width: 214px;
  height: 100%;
  background: #f0f0f0;
}
#products .productsContainer .productsSub .slideContainer .slideWrap .slideItem .productsImg {
  display: flex;
  justify-content: center;
}
#products .productsContainer .productsSub .slideContainer .slideWrap .slideItem .productsImg img {
  width: 150px;
  height: 150px;
}
#products .productsContainer .productsSub .slideContainer .slideWrap .slideItem .productsName {
  text-align: center;
  font: 18px/25px "Noto Sans KR";
  color: #333;
  margin-top: auto;
}
#products .productsContainer .productsSub .slideContainer .slideWrap .slideItem:hover {
  background: #e9e9e9;
}
@keyframes moveRe {
  0% {
    transform: translate3d(0, 0, 0);
  }
  to {
    transform: translateX(-3000px);
  }
}
#products .productsContainer .productsSub .slideContainer .slideWrap:hover {
  animation-play-state: paused;
}
#products .productsContainer .productsSub .btnWrap {
  width: 100%;
  height: 100%;
  flex: 1.2;
  display: flex;
  gap: 0px;
}
#products .productsContainer .productsSub .btnWrap .arrowBtns {
  width: 22.2222222222%;
  height: 100%;
  display: flex;
  text-align: center;
  justify-content: center;
}
#products .productsContainer .productsSub .btnWrap .arrowBtns .leftArrowBtn {
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  flex: 1;
  background: #171717;
  font: 26px "Noto Sans KR";
  color: #eee;
  cursor: pointer;
}
#products .productsContainer .productsSub .btnWrap .arrowBtns .rigtArrowBtn {
  width: 100%;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  flex: 1;
  background: #171717;
  font: 26px/5px "Noto Sans KR";
  color: #eee;
  cursor: pointer;
}
#products .productsContainer .productsSub .btnWrap .circleBtns {
  width: 25%;
  height: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 0px 0vw 0px;
  gap: 20px;
}
#products .productsContainer .productsSub .btnWrap .circleBtns button {
  width: 15px;
  height: 15px;
  border-radius: 50%;
  border: none;
  background: #cccccc;
  cursor: pointer;
}
#products .productsContainer .productsSub .btnWrap .circleBtns button.on {
  background: #171717;
}
#products .productsContainer .productsSub .btnWrap .hyperBtns {
  width: 25%;
  height: 100%;
  font: 16px/1 "Noto Sans KR";
  color: #333;
  display: flex;
  padding: 0px 0vw 0px;
  justify-content: left;
  align-items: center;
  cursor: pointer;
}

@media screen and (max-width: 1023px) {
  #products {
    width: 100vw;
    height: 500px;
    background: #f9f9f9;
    display: flex;
    align-items: center;
    justify-content: center;
    padding: 96px 5vw 96px;
  }
  #products .productsContainer {
    width: 100%;
    height: 100%;
    display: flex;
    flex-direction: column;
    align-items: center;
    justify-content: center;
  }
  #products .productsContainer .productsTit {
    width: 100%;
    height: 100%;
    flex: 2;
    background: #f9f9f9;
    font: bold 56px/1 "Noto Sans KR";
    color: #333;
  }
  #products .productsContainer .productsSub {
    width: 100%;
    height: 100%;
    flex: 1;
    display: flex;
    flex-wrap: wrap;
    flex-direction: column;
    padding: 0px 0vw 0px;
  }
  #products .productsContainer .productsSub .slideContainer {
    width: 100%;
    overflow: hidden;
    display: flex;
    height: 50%;
    flex: 2.5;
    position: relative;
  }
  #products .productsContainer .productsSub .slideContainer .slideWrap {
    gap: 20px;
    display: flex;
    animation: moveRe 20s linear infinite;
    animation-delay: 0s;
    justify-content: center;
  }
  #products .productsContainer .productsSub .slideContainer .slideWrap .slideItem {
    width: 214px;
    height: 100%;
    background: #f0f0f0;
  }
  #products .productsContainer .productsSub .slideContainer .slideWrap .slideItem .productsImg {
    display: flex;
    justify-content: center;
  }
  #products .productsContainer .productsSub .slideContainer .slideWrap .slideItem .productsImg img {
    width: 150px;
    height: 150px;
  }
  #products .productsContainer .productsSub .slideContainer .slideWrap .slideItem .productsName {
    text-align: center;
    font: 18px/25px "Noto Sans KR";
    color: #333;
    margin-top: auto;
  }
  #products .productsContainer .productsSub .slideContainer .slideWrap .slideItem:hover {
    background: #e9e9e9;
  }
  @keyframes moveRe {
    0% {
      transform: translate3d(0, 0, 0);
    }
    to {
      transform: translateX(-3000px);
    }
  }
  #products .productsContainer .productsSub .slideContainer .slideWrap:hover {
    animation-play-state: paused;
  }
  #products .productsContainer .productsSub .btnWrap {
    width: 100%;
    height: 100%;
    flex: 1.2;
    display: flex;
    gap: 0px;
  }
  #products .productsContainer .productsSub .btnWrap .arrowBtns {
    width: 22.2222222222%;
    height: 100%;
    display: flex;
    text-align: center;
    justify-content: center;
  }
  #products .productsContainer .productsSub .btnWrap .arrowBtns .leftArrowBtn {
    width: 100%;
    height: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
    flex: 1;
    background: #171717;
    font: 26px "Noto Sans KR";
    color: #eee;
    cursor: pointer;
  }
  #products .productsContainer .productsSub .btnWrap .arrowBtns .rigtArrowBtn {
    width: 100%;
    height: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
    flex: 1;
    background: #171717;
    font: 26px/5px "Noto Sans KR";
    color: #eee;
    cursor: pointer;
  }
  #products .productsContainer .productsSub .btnWrap .circleBtns {
    width: 25%;
    height: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
    padding: 0px 0vw 0px;
    gap: 20px;
  }
  #products .productsContainer .productsSub .btnWrap .circleBtns button {
    width: 15px;
    height: 15px;
    border-radius: 50%;
    border: none;
    background: #cccccc;
    cursor: pointer;
  }
  #products .productsContainer .productsSub .btnWrap .circleBtns button.on {
    background: #171717;
  }
  #products .productsContainer .productsSub .btnWrap .hyperBtns {
    width: 25%;
    height: 100%;
    font: 16px/1 "Noto Sans KR";
    color: #333;
    display: flex;
    padding: 0px 0vw 0px;
    justify-content: left;
    align-items: center;
    cursor: pointer;
  }
}
#room {
  width: 100vw;
  height: 999px;
  display: flex;
  justify-content: center;
  align-items: center;
  padding: 96px 10vw 96px;
  position: relative;
}
#room .roomContainer {
  width: 100%;
  height: 780px;
  display: flex;
  flex-direction: column;
  flex-wrap: wrap;
  position: relative;
}
#room .roomContainer .roomBg {
  flex: 7;
  background-image: url(../img/bg1.png);
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
  transform: scaleX(-1);
}
#room .roomContainer .roomBtns {
  flex: 1;
  display: flex;
  gap: 20px;
  align-items: center;
  padding-left: 3vw;
}
#room .roomContainer .roomBtns button {
  width: 140px;
  height: 40px;
  border: none;
  background: transparent;
  color: #333;
  border-radius: 50px;
  border: 1px solid rgba(23, 23, 23, 0.5);
  font: 15px/1 "Work Sans";
  letter-spacing: 0.5px;
  cursor: pointer;
}
#room .roomContainer .roomBtns button.on {
  background: #171717;
  color: #eee;
}
#room .previewContainer {
  width: 350px;
  height: 480px;
  background: #eee;
  position: absolute;
  display: flex;
  flex-wrap: wrap;
  justify-content: center;
  align-items: center;
  margin-right: 50px;
  right: 250px;
  bottom: 145px;
  padding: 30px 0 30px;
  border: 1px solid rgba(23, 23, 23, 0.4);
}
#room .previewContainer .previewBg {
  width: 290px;
  height: 183px;
  background-image: url(../img/bg1.png);
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
  transform: scaleX(-1);
}
#room .previewContainer .previewTxt {
  width: 290px;
  height: 235px;
  padding: 20px 0 0;
}
#room .previewContainer .previewTxt h3 {
  font: 30px/1 "Work Sans";
  color: #333;
  margin-bottom: 20px;
}
#room .previewContainer .previewTxt p {
  font: 18px/1 "Work Sans";
  color: rgba(16, 16, 16, 0.6);
  text-align: justify;
  word-break: break-all;
  letter-spacing: 0.1px;
}

@media screen and (max-width: 639px) {
  #room {
    width: 100vw;
    height: 650px;
    display: flex;
    justify-content: center;
    align-items: center;
    padding: 96px 10vw 96px;
    position: relative;
  }
  #room .roomContainer {
    width: 100%;
    height: 780px;
    display: flex;
    flex-direction: column;
    flex-wrap: wrap;
    position: relative;
  }
  #room .roomContainer .roomBg {
    display: none;
  }
  #room .roomContainer .roomBtns {
    display: none;
  }
  #room .previewContainer {
    width: 350px;
    height: 480px;
    background: #eee;
    display: flex;
    flex-wrap: wrap;
    justify-content: center;
    align-items: center;
    left: 5vw;
    top: 90px;
    bottom: 145px;
    padding: 30px 0 30px;
    border: 1px solid rgba(23, 23, 23, 0.4);
  }
  #room .previewContainer .previewBg {
    width: 290px;
    height: 183px;
    background-image: url(../img/bg1.png);
    background-position: center;
    background-repeat: no-repeat;
    background-size: cover;
    transform: scaleX(-1);
  }
  #room .previewContainer .previewTxt {
    width: 290px;
    height: 235px;
    padding: 20px 0 0;
  }
  #room .previewContainer .previewTxt h3 {
    font: 30px/1 "Work Sans";
    color: #333;
    margin-bottom: 20px;
  }
  #room .previewContainer .previewTxt p {
    font: 18px/1 "Work Sans";
    color: rgba(16, 16, 16, 0.6);
    text-align: justify;
    word-break: break-all;
    letter-spacing: 0.1px;
  }
}
#vids {
  width: 100vw;
  height: 950px;
  background: #f9f9f9;
  padding: 96px 10vw 120px;
  display: flex;
  justify-content: center;
  align-items: center;
}
#vids .vidsContainer {
  width: 100%;
  height: 100%;
  display: flex;
  flex-direction: column;
}
#vids .vidsContainer .vidsTextWrap {
  flex: 1;
  display: flex;
  flex-wrap: wrap;
  padding-bottom: 1vw;
}
#vids .vidsContainer .vidsTextWrap .vidsTit {
  flex: 1.65;
  font: bold 70px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 50px;
}
#vids .vidsContainer .vidsTextWrap .vidsSub {
  flex: 1;
  font: 24px/1.3 "Noto Sans KR";
  color: rgba(16, 16, 16, 0.6);
  text-align: justify;
  word-break: break-all;
  letter-spacing: 0.1px;
  margin-bottom: 30px;
}
#vids .vidsContainer .vidsTextWrap .vidsSub strong {
  font: bold 24px/1 "Noto Sans KR";
  color: #333;
  letter-spacing: 0.1px;
}
#vids .vidsContainer .vidsVideoWrap {
  flex: 2.5;
  display: flex;
  gap: 30px;
}
#vids .vidsContainer .vidsVideoWrap .video {
  width: 20%;
  height: 93%;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  text-align: center;
  flex: 1;
  position: relative;
  background-blend-mode: multiply;
}
#vids .vidsContainer .vidsVideoWrap .video .vidsNum {
  flex: 1;
  width: 100%;
  height: 20px;
  font: 26px/4 "Noto Sans KR";
  color: #e9e9e9;
  border-bottom: 1px solid #ddd;
  cursor: pointer;
  backdrop-filter: brightness(0.8);
}
#vids .vidsContainer .vidsVideoWrap .video .vidsBarTit {
  width: 100%;
  flex: 3.5;
  font: 24px/7 "Noto Sans KR";
  color: #e9e9e9;
  writing-mode: vertical-rl;
  padding-top: 1.5vw;
  text-align: left;
  cursor: pointer;
  backdrop-filter: brightness(0.8);
}
#vids .vidsContainer .vidsVideoWrap .video.on {
  flex: 5;
  background: #a3a3a3;
  animation: videoMove 0.5s linear;
  background-position: center;
  background-size: cover;
  background-repeat: no-repeat;
  animation-fill-mode: backwards;
  animation-duration: 0.5s;
  position: relative;
  color: white;
  overflow: hidden;
}
#vids .vidsContainer .vidsVideoWrap .video.on .vidsOnSpan {
  backdrop-filter: blur(10px) opacity(0.3);
  width: 100%;
  height: 100%;
  padding: 100px 5vw 60px;
}
#vids .vidsContainer .vidsVideoWrap .video.on .vidsOnSpan h4 {
  color: #e9e9e9;
  font: 20px/1 "Noto Sans KR";
  text-align: left;
  margin-bottom: 10px;
}
#vids .vidsContainer .vidsVideoWrap .video.on .vidsOnSpan h2 {
  color: #eee;
  width: 600px;
  font: 30px/1.2 "Noto Sans KR";
  text-align: left;
  z-index: 999;
  text-align: justify;
  word-break: break-all;
}
#vids .vidsContainer .vidsVideoWrap .video.on .vidsOnSpan p {
  color: #e9e9e9;
  width: 600px;
  text-align: justify;
  word-break: break-all;
  font: 18px/1.5 "Noto Sans KR";
  text-align: left;
  margin-top: 2vw;
  margin-bottom: 96px;
}
#vids .vidsContainer .vidsVideoWrap .video.on .discoverBtn {
  content: "Discover Now";
  position: absolute;
  float: right;
  bottom: 0;
  right: 0;
  width: 209px;
  height: 71px;
  background: #623fe4;
  border: none;
  font: 16px/71px "Noto Sans KR";
  color: #e9e9e9;
  cursor: pointer;
  align-items: flex-end;
}
#vids .vidsContainer .vidsVideoWrap .video.on .discoverBtn:hover {
  background: #fec202;
  color: #171717;
}
@keyframes videoMove {
  from {
    flex: 1;
    writing-mode: vertical-rl;
  }
  to {
    flex: 5;
  }
}
#vids p {
  margin-top: 20px;
  text-align: end;
  font: 16px/1 "Noto Sans KR";
  color: #333;
  cursor: pointer;
}

@media screen and (max-width: 1023px) {
  #vids {
    height: 900px;
    padding: 60px 5vw 120px;
  }
  #vids .vidsContainer .vidsTextWrap {
    display: block;
  }
  #vids .vidsContainer .vidsTextWrap .vidsTit {
    width: 100%;
    height: 50px;
    flex: 1.65;
    font: bold 56px/1 "Noto Sans KR";
    color: #333;
    margin-bottom: 50px;
  }
  #vids .vidsContainer .vidsTextWrap .vidsSub {
    flex: 1;
    width: 60%;
    font: 14.4px/1.5 "Noto Sans KR";
    color: rgba(16, 16, 16, 0.6);
    text-align: justify;
    word-break: break-all;
    letter-spacing: 0.1px;
    margin-bottom: 50px;
  }
  #vids .vidsContainer .vidsTextWrap .vidsSub strong {
    font: bold 14.4px/1.5 "Noto Sans KR";
    color: #333;
    letter-spacing: 0.1px;
  }
  #vids .vidsContainer .vidsVideoWrap {
    flex: 2.5;
    display: flex;
    gap: 30px;
  }
  #vids .vidsContainer .vidsVideoWrap .video {
    width: 33.3333333333%;
    height: 93%;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    text-align: center;
    flex: 1;
    position: relative;
    background-blend-mode: multiply;
  }
  #vids .vidsContainer .vidsVideoWrap .video .vidsNum {
    flex: 1;
    width: 100%;
    height: 20px;
    font: 24px/4 "Noto Sans KR";
    color: #e9e9e9;
    border-bottom: 1px solid #ddd;
    cursor: pointer;
    backdrop-filter: brightness(0.8);
  }
  #vids .vidsContainer .vidsVideoWrap .video .vidsBarTit {
    width: 100%;
    flex: 3.5;
    font: 19px/7 "Noto Sans KR";
    color: #e9e9e9;
    writing-mode: vertical-rl;
    padding-top: 3vw;
    text-align: left;
    cursor: pointer;
    backdrop-filter: brightness(0.8);
  }
  #vids .vidsContainer .vidsVideoWrap .video.on {
    flex: 3;
    background: #a3a3a3;
    animation: videoMove 0.5s linear;
    background-position: center;
    background-size: cover;
    background-repeat: no-repeat;
    animation-fill-mode: backwards;
    animation-duration: 0.5s;
    position: relative;
    color: white;
    overflow: visible;
  }
  #vids .vidsContainer .vidsVideoWrap .video.on .vidsOnSpan {
    backdrop-filter: blur(10px) opacity(0.3);
    padding: 100px 5vw 0px;
  }
  #vids .vidsContainer .vidsVideoWrap .video.on .vidsOnSpan h4 {
    position: relative;
    color: #e9e9e9;
    font: 19.2px/1 "Noto Sans KR";
    text-align: left;
    margin-bottom: 10px;
  }
  #vids .vidsContainer .vidsVideoWrap .video.on .vidsOnSpan h2 {
    color: #eee;
    width: 90%;
    font: 19.2px/1.2 "Noto Sans KR";
    text-align: left;
    z-index: 999;
  }
  #vids .vidsContainer .vidsVideoWrap .video.on .vidsOnSpan p {
    display: none;
    color: #e9e9e9;
    width: 330px;
    text-align: justify;
    word-break: break-all;
    font: 14.4px/1.5 "Noto Sans KR";
    text-align: left;
    margin-top: 2vw;
    margin-bottom: 96px;
  }
  #vids .vidsContainer .vidsVideoWrap .video.on .discoverBtn {
    content: "Discover Now";
    position: absolute;
    bottom: 0px;
    right: 0px;
    width: 209px;
    height: 71px;
    background: #623fe4;
    border: none;
    font: 14.4px/71px "Noto Sans KR";
    color: #e9e9e9;
    cursor: pointer;
  }
  #vids .vidsContainer .vidsVideoWrap .video.on .discoverBtn:hover {
    background: #fec202;
    color: #171717;
  }
  @keyframes videoMove {
    from {
      flex: 1;
      writing-mode: vertical-rl;
    }
    to {
      flex: 5;
    }
  }
  #vids p {
    margin-top: 20px;
    text-align: end;
    font: 14.4px/1 "Noto Sans KR";
    color: #333;
    cursor: pointer;
  }
}
@media screen and (max-width: 639px) {
  #vids {
    height: 900px;
    padding: 60px 5vw 120px;
  }
  #vids .vidsContainer .vidsTextWrap {
    display: block;
  }
  #vids .vidsContainer .vidsTextWrap .vidsTit {
    width: 100%;
    height: 50px;
    flex: 1.65;
    font: bold 49px/1 "Noto Sans KR";
    color: #333;
    margin-bottom: 50px;
  }
  #vids .vidsContainer .vidsTextWrap .vidsSub {
    flex: 1;
    width: 70%;
    font: 12.6px/1.5 "Noto Sans KR";
    color: rgba(16, 16, 16, 0.6);
    text-align: justify;
    word-break: break-all;
    letter-spacing: 0.1px;
    margin-bottom: 50px;
  }
  #vids .vidsContainer .vidsTextWrap .vidsSub strong {
    font: bold 12.6px/1.5 "Noto Sans KR";
    color: #333;
    letter-spacing: 0.1px;
  }
  #vids .vidsContainer .vidsVideoWrap {
    flex: 2.5;
    display: flex;
    gap: 30px;
  }
  #vids .vidsContainer .vidsVideoWrap .video {
    width: 33.3333333333%;
    height: 93%;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    text-align: center;
    flex: 1;
    position: relative;
    background-blend-mode: multiply;
  }
  #vids .vidsContainer .vidsVideoWrap .video .vidsNum {
    flex: 1;
    width: 100%;
    height: 20px;
    font: 16.8px/6 "Noto Sans KR";
    color: #e9e9e9;
    border-bottom: 1px solid #ddd;
    cursor: pointer;
    backdrop-filter: brightness(0.8);
  }
  #vids .vidsContainer .vidsVideoWrap .video .vidsBarTit {
    width: 100%;
    flex: 3.5;
    font: 16.8px/7 "Noto Sans KR";
    color: #e9e9e9;
    writing-mode: vertical-rl;
    padding-top: 10vw;
    text-align: left;
    cursor: pointer;
    backdrop-filter: brightness(0.8);
  }
  #vids .vidsContainer .vidsVideoWrap .video.on {
    flex: 3;
    background: #a3a3a3;
    animation: videoMove 0.5s linear;
    background-position: center;
    background-size: cover;
    background-repeat: no-repeat;
    animation-fill-mode: backwards;
    animation-duration: 0.5s;
    position: relative;
    color: white;
    overflow: visible;
  }
  #vids .vidsContainer .vidsVideoWrap .video.on .vidsOnSpan {
    backdrop-filter: blur(10px) opacity(0.3);
    padding: 160px 5vw 0px;
  }
  #vids .vidsContainer .vidsVideoWrap .video.on .vidsOnSpan h4 {
    position: relative;
    color: #e9e9e9;
    font: 11.2px/1 "Noto Sans KR";
    text-align: left;
    margin-bottom: 10px;
  }
  #vids .vidsContainer .vidsVideoWrap .video.on .vidsOnSpan h2 {
    color: #eee;
    width: 90%;
    font: 16.8px/1.2 "Noto Sans KR";
    text-align: left;
    z-index: 999;
  }
  #vids .vidsContainer .vidsVideoWrap .video.on .vidsOnSpan p {
    display: none;
    color: #e9e9e9;
    width: 330px;
    text-align: justify;
    word-break: break-all;
    font: 12.6px/1.5 "Noto Sans KR";
    text-align: left;
    margin-top: 2vw;
    margin-bottom: 96px;
  }
  #vids .vidsContainer .vidsVideoWrap .video.on .discoverBtn {
    content: "Discover Now";
    position: absolute;
    bottom: 0px;
    right: 0px;
    width: 209px;
    height: 71px;
    background: #623fe4;
    border: none;
    font: 14.4px/71px "Noto Sans KR";
    color: #e9e9e9;
    cursor: pointer;
  }
  #vids .vidsContainer .vidsVideoWrap .video.on .discoverBtn:hover {
    background: #fec202;
    color: #171717;
  }
  @keyframes videoMove {
    from {
      flex: 1;
      writing-mode: vertical-rl;
    }
    to {
      flex: 5;
    }
  }
  #vids p {
    margin-top: 20px;
    text-align: end;
    font: 12.6px/1 "Noto Sans KR";
    color: #333;
    cursor: pointer;
  }
}
#smartHome {
  width: 100vw;
  height: 790px;
  background: url(../img/smartHomeBg3.png);
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
}
#smartHome .container {
  max-width: 100%;
  height: 100%;
  margin: 0 auto;
  padding: 150px 10vw 96px;
  position: relative;
}
#smartHome .swiper-container {
  width: 100%;
  height: 100%;
  position: static;
}
#smartHome .swiper-container .swiper-wrapper .swiper-slide {
  text-align: center;
  width: 350px;
  height: 465px;
  background: rgb(255, 255, 255);
  border-radius: 10px;
  background: transparent;
  border: 1px solid white;
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
  padding: 80px 45px;
  position: relative;
}
#smartHome .swiper-container .swiper-wrapper .swiper-slide h4 {
  position: relative;
  font: 18px/1 "Noto Sans KR";
  color: #eee;
  margin-bottom: 130px;
  z-index: 1;
  text-align: left;
}
#smartHome .swiper-container .swiper-wrapper .swiper-slide h2 {
  position: relative;
  font: bold 30px/1 "Noto Sans KR";
  color: #eee;
  z-index: 1;
  margin-bottom: 100px;
  text-align: left;
}
#smartHome .swiper-container .swiper-wrapper .swiper-slide .animation {
  font: 154px/1 "Work Sans";
  position: absolute;
  z-index: 1000;
  bottom: -72px;
  right: 72px;
  transform: translate(-50% 50%);
  text-align: right;
  color: transparent;
  -webkit-text-stroke: 1px #eee;
}
#smartHome .swiper-container .swiper-wrapper .swiper-slide .animation.movingText {
  animation: fillingText 1s infinite;
  animation-fill-mode: forwards;
  animation-duration: 1s;
}
@keyframes fillingText {
  0% {
    transform: translateX(0);
  }
  100% {
    color: #eee;
    transform: translateX(100px);
  }
}
#smartHome .swiper-container .swiper-button-prev {
  position: absolute;
  top: 50%;
  left: 50px;
  width: 45px;
  height: 45px;
  transform: translateY(-50%);
  margin-top: 0px;
}
#smartHome .swiper-container .swiper-button-next {
  position: absolute;
  top: 50%;
  right: 50px;
  width: 45px;
  height: 45px;
  transform: translateY(-50%);
  margin-top: 0px;
}

@media screen and (max-width: 1023px) {
  #smartHome {
    width: 100vw;
    height: 790px;
    background: url(../img/smartHomeBg3.png);
    background-position: center;
    background-repeat: no-repeat;
    background-size: cover;
  }
  #smartHome .container {
    max-width: 100%;
    height: 100%;
    margin: 0 auto;
    padding: 150px 5vw 96px;
    position: relative;
  }
  #smartHome .swiper-container {
    width: 100%;
    height: 100%;
    position: static;
  }
  #smartHome .swiper-container .swiper-wrapper .swiper-slide {
    text-align: center;
    width: 350px;
    height: 465px;
    background: rgb(255, 255, 255);
    border-radius: 10px;
    background: transparent;
    background-position: center;
    background-repeat: no-repeat;
    background-size: cover;
    padding: 80px 45px;
    position: relative;
  }
  #smartHome .swiper-container .swiper-wrapper .swiper-slide h4 {
    position: relative;
    font: 14.4px/1 "Noto Sans KR";
    color: #eee;
    margin-bottom: 130px;
    z-index: 1;
    text-align: left;
  }
  #smartHome .swiper-container .swiper-wrapper .swiper-slide h2 {
    position: relative;
    font: bold 24px/1 "Noto Sans KR";
    color: #eee;
    z-index: 1;
    margin-bottom: 100px;
    text-align: left;
  }
  #smartHome .swiper-container .swiper-wrapper .swiper-slide .animation {
    font: 140px/1 "Work Sans";
    position: absolute;
    z-index: 1000;
    bottom: -72px;
    right: 72px;
    transform: translate(-50% 50%);
    text-align: right;
    color: transparent;
    -webkit-text-stroke: 1px #eee;
  }
  #smartHome .swiper-container .swiper-wrapper .swiper-slide .animation.movingText {
    animation: fillingText 1s infinite;
    animation-fill-mode: forwards;
    animation-duration: 1s;
  }
  @keyframes fillingText {
    0% {
      transform: translateX(0);
    }
    100% {
      color: #eee;
      transform: translateX(100px);
    }
  }
  #smartHome .swiper-container .swiper-button-prev {
    position: absolute;
    top: 50%;
    left: 50px;
    width: 30px;
    height: 30px;
    transform: translateY(-50%);
    margin-top: 0px;
  }
  #smartHome .swiper-container .swiper-button-next {
    position: absolute;
    top: 50%;
    right: 50px;
    width: 30px;
    height: 30px;
    transform: translateY(-50%);
    margin-top: 0px;
  }
}
@media screen and (max-width: 1023px) {
  #smartHome {
    width: 100vw;
    height: 790px;
    background: url(../img/smartHomeBg3.png);
    background-position: center;
    background-repeat: no-repeat;
    background-size: cover;
  }
  #smartHome .container {
    max-width: 100%;
    height: 100%;
    margin: 0 auto;
    padding: 150px 10vw 96px;
    position: relative;
  }
  #smartHome .swiper-container {
    width: 100%;
    height: 100%;
    position: static;
  }
  #smartHome .swiper-container .swiper-wrapper .swiper-slide {
    text-align: center;
    width: 350px;
    height: 465px;
    background: rgb(255, 255, 255);
    border-radius: 10px;
    background: transparent;
    background-position: center;
    background-repeat: no-repeat;
    background-size: cover;
    padding: 80px 45px;
    position: relative;
  }
  #smartHome .swiper-container .swiper-wrapper .swiper-slide h4 {
    position: relative;
    font: 12.6px/1 "Noto Sans KR";
    color: #eee;
    margin-bottom: 130px;
    z-index: 1;
    text-align: left;
  }
  #smartHome .swiper-container .swiper-wrapper .swiper-slide h2 {
    position: relative;
    font: bold 21px/1 "Noto Sans KR";
    color: #eee;
    z-index: 1;
    margin-bottom: 100px;
    text-align: left;
  }
  #smartHome .swiper-container .swiper-wrapper .swiper-slide .animation {
    font: 140px/1 "Work Sans";
    position: absolute;
    z-index: 1000;
    bottom: -72px;
    right: 72px;
    transform: translate(-50% 50%);
    text-align: right;
    color: transparent;
    -webkit-text-stroke: 1px #eee;
  }
  #smartHome .swiper-container .swiper-wrapper .swiper-slide .animation.movingText {
    animation: fillingText 1s infinite;
    animation-fill-mode: forwards;
    animation-duration: 1s;
  }
  @keyframes fillingText {
    0% {
      transform: translateX(0);
    }
    100% {
      color: #eee;
      transform: translateX(100px);
    }
  }
  #smartHome .swiper-container .swiper-button-prev {
    position: absolute;
    top: 50%;
    left: 50px;
    width: 30px;
    height: 30px;
    transform: translateY(-50%);
    margin-top: 0px;
  }
  #smartHome .swiper-container .swiper-button-next {
    position: absolute;
    top: 50%;
    right: 50px;
    width: 30px;
    height: 30px;
    transform: translateY(-50%);
    margin-top: 0px;
  }
}
#news {
  width: 100vw;
  height: 860px;
  display: flex;
  background: #f9f9f9;
}
#news .grid {
  display: grid;
  grid-template-columns: 300px 50px 100px 50px 50px 50px 50px 300px;
  overflow: hidden;
  width: 80%;
  height: 860px;
  border: 1px solid rgba(233, 233, 233, 0.7);
  z-index: 0;
  position: relative;
}
#news .grid:nth-of-type(1) {
  width: 200px;
}
#news .grid:nth-of-type(8) {
  width: 200px;
}
#news .marquee {
  width: 100vw;
  height: 120px;
  display: flex;
  overflow: hidden;
  flex-direction: column;
  position: absolute;
  margin-top: 38.5vw;
  z-index: 0;
}
#news .marquee span {
  width: 100vw;
  height: 120px;
  font: 140px/1 "Work Sans";
  color: #f9f9f9;
  background: -webkit-linear-gradient(left, #32aaff 0%, #4edd8e 27%, #fadb29 64%, #f07569 100%);
  -webkit-text-stroke: 3px rgba(255, 255, 255, 0.01);
  -webkit-background-clip: text;
  white-space: nowrap;
  will-change: transform;
  pointer-events: none;
}
@keyframes marquee {
  from {
    transform: translateX(0%);
  }
  to {
    transform: translateX(-135%);
  }
}
#news .newsContainer {
  padding: 150px 10vw 150px;
  display: flex;
  flex-wrap: wrap;
  width: 100%;
  height: 100%;
  z-index: 1;
  flex-wrap: wrap;
}
#news .newsContainer .leftWrap {
  flex: 1;
  display: flex;
  flex-direction: column;
}
#news .newsContainer .leftWrap .titWrap {
  flex: 2.8;
  align-items: center;
  position: relative;
}
#news .newsContainer .leftWrap .titWrap h2 {
  position: relative;
  font: 70px/1 "Work Sans";
  color: #333;
  top: 4vw;
}
#news .newsContainer .leftWrap .titWrap P {
  width: 500px;
  position: relative;
  font: 20px/1.2 "Work Sans";
  color: #333;
  top: 6vw;
  text-align: justify;
  word-break: break-all;
}
#news .newsContainer .leftWrap .loadingWrap {
  flex: 1.2;
  display: flex;
  justify-content: center;
  text-align: left;
  font: 26px/1 "Work Sans";
}
#news .newsContainer .leftWrap .loadingWrap .swiper-pagination {
  overflow: hidden;
  width: 50%;
  flex: 1.4;
  position: relative;
  width: calc(100% - 150px);
  height: 10px;
  bottom: auto;
}
#news .newsContainer .leftWrap .loadingWrap .loadingBtns {
  width: 50%;
  flex: 1;
  margin-top: -0.6vw;
  color: #333;
  font: bold 26px/1 "Work Sans";
}
#news .newsContainer .leftWrap .loadingWrap .loadingBtns .swiper-progress-bar {
  position: relative;
  width: 50%;
  display: inline-block;
  z-index: 1;
  height: 2px;
  background: greenyellow;
}
#news .newsContainer .leftWrap .loadingWrap .loadingBtns .swiper-progress-bar .slide_progress-bar {
  height: 2px;
  background: hotpink;
  width: auto;
  clear: both;
  opacity: 0;
  bottom: 45px;
  left: 0;
  right: 0;
}
#news .newsContainer .leftWrap .loadingWrap .loadingBtns .swiper-progress-bar .slide_progress-bar:after {
  position: absolute;
  top: 0;
  left: 0;
  background: #000;
  height: 100%;
  width: 0;
  content: "";
  transition: 0.1s width linear;
}
#news .newsContainer .leftWrap .loadingWrap .loadingBtns .swiper-progress-bar.active .slide_progress-bar {
  opacity: 1;
}
#news .newsContainer .leftWrap .loadingWrap .loadingBtns .swiper-progress-bar.animate .slide_progress-bar:after {
  transition: width linear;
  transition-delay: unset;
  width: 100%;
  transition-duration: 5s;
}
#news .newsContainer .leftWrap .loadingWrap .loadingBtns button {
  width: 30px;
  height: 30px;
  font: 26px/1 "Work Sans";
  color: #333;
  border: none;
  background: transparent;
}
#news .newsContainer .leftWrap .loadingWrap .loadingBtns button .fa-chevron-right {
  cursor: pointer;
}
#news .newsContainer .leftWrap .loadingWrap .loadingBtns button {
  width: 30px;
  height: 30px;
  font: 26px/1 "Work Sans";
  color: #333;
  border: none;
  background: transparent;
}
#news .newsContainer .leftWrap .loadingWrap .loadingBtns button .fa-chevron-left {
  cursor: pointer;
}
#news .newsContainer .leftWrap .loadingWrap .loadingBtns button {
  width: 30px;
  height: 30px;
  font: 30px/1 "Work Sans";
  color: #333;
  border: none;
  background: transparent;
}
#news .newsContainer .leftWrap .loadingWrap .loadingBtns button .fa-pause {
  cursor: pointer;
}
#news .newsContainer .leftWrap .loadingWrap .loadingBtns button {
  width: 30px;
  height: 30px;
  font: 26px/1 "Work Sans";
  color: #333;
  border: none;
  background: transparent;
}
#news .newsContainer .leftWrap .loadingWrap .loadingBtns button .fa-play {
  cursor: pointer;
  display: none;
}
#news .newsContainer .swiper-container {
  width: 30%;
  flex: 1.3;
  display: inline-flex;
  overflow: hidden;
}
#news .newsContainer .swiper-container .swiper-wrapper {
  display: flex;
  align-items: center;
}
#news .newsContainer .swiper-container .swiper-wrapper:nth-of-type(odd) {
  margin-top: 4vw;
}
#news .newsContainer .swiper-container .swiper-wrapper:nth-of-type(even) {
  margin-top: -4vw;
}
#news .newsContainer .swiper-container .swiper-wrapper .swiper-slide {
  border-radius: 10px;
  position: relative;
  width: 356px;
  height: 508.25px;
  cursor: pointer;
  text-align: center;
  padding: 60px 2vw 30px;
  background-blend-mode: multiply;
  box-shadow: rgba(0, 0, 0, 0.45) 0px 25px 20px -20px;
}
#news .newsContainer .swiper-container .swiper-wrapper .swiper-slide.on {
  background: #cccccc;
  background-size: cover;
  background-repeat: no-repeat;
  background-position: center;
}
#news .newsContainer .swiper-container .swiper-wrapper .swiper-slide img {
  width: 356px;
  height: 456px;
}
#news .newsContainer .swiper-container .swiper-wrapper .swiper-slide h4 {
  color: #eee;
  font: 18px/1 "Work Sans";
  z-index: 4;
  position: relative;
}
#news .newsContainer .swiper-container .swiper-wrapper .swiper-slide h2 {
  color: #eee;
  font: bold 30px/1 "Work Sans";
  margin-top: 10vw;
}
#news .newsContainer .swiper-container .swiper-wrapper .swiper-slide p {
  color: #eee;
  font: 18px/1 "Work Sans";
  margin-top: 1vw;
}

@media screen and (max-width: 639px) {
  #news {
    width: 100vw;
    height: 960px;
    display: flex;
    background: #f9f9f9;
  }
  #news .grid {
    display: grid;
    grid-template-columns: 300px 50px 100px 50px 50px 50px 50px 300px;
    overflow: hidden;
    width: 80%;
    height: 860px;
    border: 1px solid rgba(233, 233, 233, 0.7);
    z-index: 0;
    position: relative;
  }
  #news .grid:nth-of-type(1) {
    width: 200px;
  }
  #news .grid:nth-of-type(8) {
    width: 200px;
  }
  #news .marquee {
    width: 100vw;
    height: 120px;
    display: flex;
    overflow: hidden;
    flex-direction: column;
    position: absolute;
    margin-top: 38.5vw;
    z-index: 0;
  }
  #news .marquee span {
    width: 100vw;
    height: 120px;
    font: 140px/1 "Work Sans";
    color: #f9f9f9;
    background: -webkit-linear-gradient(left, #32aaff 0%, #4edd8e 27%, #fadb29 64%, #f07569 100%);
    -webkit-text-stroke: 3px rgba(255, 255, 255, 0.01);
    -webkit-background-clip: text;
    white-space: nowrap;
    will-change: transform;
    pointer-events: none;
  }
  @keyframes marquee {
    from {
      transform: translateX(0%);
    }
    to {
      transform: translateX(-135%);
    }
  }
  #news .newsContainer {
    padding: 100px 5vw 100px;
    display: flex;
    flex-wrap: wrap;
    width: 100%;
    height: 100%;
    z-index: 1;
    flex-direction: column;
  }
  #news .newsContainer .leftWrap {
    flex: 1;
    display: flex;
    flex-direction: column;
  }
  #news .newsContainer .leftWrap .titWrap {
    flex: 2;
    align-items: center;
    position: relative;
  }
  #news .newsContainer .leftWrap .titWrap h2 {
    position: relative;
    font: 50px/1 "Work Sans";
    color: #333;
    top: 4vw;
    margin-bottom: 20px;
  }
  #news .newsContainer .leftWrap .titWrap P {
    width: 100%;
    position: relative;
    font: 18px/1.2 "Work Sans";
    color: #333;
    top: 6vw;
    text-align: justify;
    word-break: break-all;
    margin-bottom: 40px;
  }
  #news .newsContainer .leftWrap .loadingWrap {
    flex: 1.2;
    width: 100%;
    display: flex;
    justify-content: center;
    text-align: left;
    font: 18px/1 "Work Sans";
  }
  #news .newsContainer .leftWrap .loadingWrap .swiper-pagination {
    overflow: hidden;
    width: 50%;
    flex: 1.4;
    font: bold 18px/1 "Work Sans";
    position: relative;
    width: calc(100% - 150px);
    height: 10px;
    bottom: auto;
  }
  #news .newsContainer .leftWrap .loadingWrap .loadingBtns {
    width: 50%;
    flex: 1;
    margin-top: -0.6vw;
    color: #333;
    font: bold 26px/1 "Work Sans";
  }
  #news .newsContainer .leftWrap .loadingWrap .loadingBtns .swiper-progress-bar {
    position: relative;
    width: 50%;
    display: inline-block;
    z-index: 1;
    height: 2px;
    background: greenyellow;
  }
  #news .newsContainer .leftWrap .loadingWrap .loadingBtns .swiper-progress-bar .slide_progress-bar {
    height: 2px;
    background: hotpink;
    width: auto;
    clear: both;
    opacity: 0;
    bottom: 45px;
    left: 0;
    right: 0;
  }
  #news .newsContainer .leftWrap .loadingWrap .loadingBtns .swiper-progress-bar .slide_progress-bar:after {
    position: absolute;
    top: 0;
    left: 0;
    background: #000;
    height: 100%;
    width: 0;
    content: "";
    transition: 0.1s width linear;
  }
  #news .newsContainer .leftWrap .loadingWrap .loadingBtns .swiper-progress-bar.active .slide_progress-bar {
    opacity: 1;
  }
  #news .newsContainer .leftWrap .loadingWrap .loadingBtns .swiper-progress-bar.animate .slide_progress-bar:after {
    transition: width linear;
    transition-delay: unset;
    width: 100%;
    transition-duration: 5s;
  }
  #news .newsContainer .leftWrap .loadingWrap .loadingBtns button {
    width: 30px;
    height: 30px;
    font: 18px/1 "Work Sans";
    color: #333;
    border: none;
    background: transparent;
  }
  #news .newsContainer .leftWrap .loadingWrap .loadingBtns button .fa-chevron-right {
    cursor: pointer;
  }
  #news .newsContainer .leftWrap .loadingWrap .loadingBtns button {
    width: 30px;
    height: 30px;
    font: 18px/1 "Work Sans";
    color: #333;
    border: none;
    background: transparent;
  }
  #news .newsContainer .leftWrap .loadingWrap .loadingBtns button .fa-chevron-left {
    cursor: pointer;
  }
  #news .newsContainer .leftWrap .loadingWrap .loadingBtns button {
    width: 30px;
    height: 30px;
    font: 18px/1 "Work Sans";
    color: #333;
    border: none;
    background: transparent;
  }
  #news .newsContainer .leftWrap .loadingWrap .loadingBtns button .fa-pause {
    cursor: pointer;
  }
  #news .newsContainer .leftWrap .loadingWrap .loadingBtns button {
    width: 30px;
    height: 30px;
    font: 18px/1 "Work Sans";
    color: #333;
    border: none;
    background: transparent;
  }
  #news .newsContainer .leftWrap .loadingWrap .loadingBtns button .fa-play {
    cursor: pointer;
    display: none;
  }
  #news .newsContainer .swiper-container {
    width: 100%;
    flex: 1.3;
    display: flex;
    flex-wrap: nowrap;
    overflow: hidden;
    height: 100%;
  }
  #news .newsContainer .swiper-container .swiper-wrapper {
    width: 100%;
    height: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
    overflow: visible;
    flex-wrap: nowrap;
  }
  #news .newsContainer .swiper-container .swiper-wrapper:nth-of-type(odd) {
    margin-top: 0vw;
  }
  #news .newsContainer .swiper-container .swiper-wrapper:nth-of-type(even) {
    margin-top: 0vw;
  }
  #news .newsContainer .swiper-container .swiper-wrapper .swiper-slide {
    border-radius: 10px;
    position: relative;
    display: flex;
    justify-content: center;
    width: 100%;
    height: 100%;
    cursor: pointer;
    text-align: center;
    padding: 60px 2vw 30px;
    background-blend-mode: multiply;
    box-shadow: none;
    background: red;
  }
  #news .newsContainer .swiper-container .swiper-wrapper .swiper-slide.on {
    background: #cccccc;
    background-size: cover;
    background-repeat: no-repeat;
    background-position: center;
  }
  #news .newsContainer .swiper-container .swiper-wrapper .swiper-slide img {
    width: 356px;
    height: 456px;
  }
  #news .newsContainer .swiper-container .swiper-wrapper .swiper-slide h4 {
    color: #eee;
    font: 18px/1 "Work Sans";
    z-index: 4;
    position: relative;
  }
  #news .newsContainer .swiper-container .swiper-wrapper .swiper-slide h2 {
    color: #eee;
    font: bold 23px/1 "Work Sans";
    margin-top: 10vw;
  }
  #news .newsContainer .swiper-container .swiper-wrapper .swiper-slide p {
    color: #eee;
    font: 18px/1 "Work Sans";
    margin-top: 1vw;
  }
}
#promotion {
  width: 100vw;
  height: 810px;
  background: linear-gradient(90deg, #2d55d6 0%, #db3885 100%);
  display: flex;
  justify-content: center;
  align-items: center;
  overflow: hidden;
}
#promotion .promotionContainer {
  width: 100vw;
  height: 820px;
  display: flex;
  flex-wrap: wrap;
  position: relative;
  justify-content: center;
  align-items: center;
  z-index: 1;
  padding: 140px 10vw 140px;
}
#promotion .promotionContainer .circleText {
  width: 540px;
  height: 540px;
  position: absolute;
  z-index: -1;
  top: -90px;
  left: -110px;
  animation: rotateImage 10s linear infinite;
  transform-origin: 50% 50%;
  opacity: 0.5;
}
@keyframes rotateImage {
  100% {
    transform: rotate(360deg);
  }
}
#promotion .promotionContainer .promotionWrap {
  width: 100%;
  height: 100%;
  overflow: hidden;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(1) {
  width: 100%;
  height: 100%;
  flex: 2;
  display: flex;
  flex-wrap: wrap;
  flex-direction: column;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(1) .top {
  flex: 1;
  width: 100%;
  height: 100%;
  margin-top: 60px;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(1) .top video {
  width: 100%;
  height: 100%;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(1) .down {
  flex: 1;
  width: 100%;
  height: 100%;
  margin-top: 25px;
  display: flex;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(1) .down .downLeft {
  flex: 1;
  width: 50%;
  height: 100%;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(1) .down .downLeft h3 {
  font: 24px/1 "Noto Sans KR";
  color: #eee;
  margin-bottom: 10px;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(1) .down .downLeft h2 {
  font: bold 24px/1 "Noto Sans KR";
  color: #eee;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(1) .down .downRight {
  flex: 0.1;
  width: 50%;
  height: 100%;
  font: 22px/1 "Noto Sans KR";
  color: #eee;
  text-align: end;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(2) {
  width: 100%;
  flex: 1;
  padding: 0;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(2) h4 {
  margin: 0px auto;
  text-orientation: upright;
  writing-mode: vertical-rl;
  white-space: wrap;
  word-spacing: -55px;
  margin-top: 15px;
  font: bold 80px/1 "Noto Sans KR";
  color: transparent;
  -webkit-text-stroke: 1px #eee;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(3) {
  width: 100%;
  flex: 2;
  overflow-x: hidden;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(3) .sns {
  flex: 1;
  width: 100%;
  height: 90%;
  overflow-y: scroll;
  overflow-x: none;
  padding-right: 50px;
  text-align: justify;
  word-break: break-all;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(3) .sns h3 {
  font: bold 24px/1 "Noto Sans KR";
  color: #eee;
  margin-bottom: 10px;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(3) .sns h4 {
  font: 18px/1.5 "Noto Sans KR";
  color: #ffc6ec;
  margin-bottom: 10px;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(3) .sns p {
  font: 16px/1 "Noto Sans KR";
  color: #eee;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(3) .sns::-webkit-scrollbar {
  width: 9px;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(3) .sns::-webkit-scrollbar-thumb {
  background-color: #e96aa6;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(3) .sns::-webkit-scrollbar-track {
  background-color: transparent;
}
#promotion .promotionContainer .promotionWrap:nth-of-type(3) .snsGoBtn {
  flex: 0.5;
  width: 100%;
  height: 10%;
  font: 16px/1 "Noto Sans KR";
  color: #eee;
  margin-left: -60px;
  text-align: end;
  margin-top: 20px;
}

@media screen and (max-width: 1023px) {
  #promotion {
    height: auto;
  }
  #promotion .promotionContainer {
    height: 1200px;
    flex-direction: column;
    padding: 60px 5vw 60px;
  }
  #promotion .promotionContainer .circleText {
    width: 540px;
    height: 540px;
    position: absolute;
    z-index: -1;
    top: -90px;
    left: -110px;
    animation: rotateImage 10s linear infinite;
    transform-origin: 50% 50%;
    opacity: 0.5;
  }
  @keyframes rotateImage {
    100% {
      transform: rotate(360deg);
    }
  }
  #promotion .promotionContainer .promotionWrap {
    height: auto;
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(1) {
    flex: 1.75;
    order: 2;
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(1) .top {
    flex: 1;
    width: 100%;
    height: 100%;
    margin-top: 0px;
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(1) .top video {
    width: 100%;
    height: 100%;
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(1) .down .downLeft h3 {
    font: 19.2px/1 "Noto Sans KR";
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(1) .down .downLeft h2 {
    font: bold 19.2px/1 "Noto Sans KR";
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(1) .down .downRight {
    font: 19px/1 "Noto Sans KR";
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(2) {
    order: 1;
    flex: 0.45;
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(2) h4 {
    writing-mode: horizontal-tb;
    margin-top: 0px;
    font: bold 56px/1 "Noto Sans KR";
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(3) {
    flex: 2;
    order: 3;
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(3) .sns {
    width: 100%;
    height: 90%;
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(3) .sns h3 {
    font: bold 19.2px/1 "Noto Sans KR";
    margin-bottom: 15px;
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(3) .sns h4 {
    font: 14.4px/1.5 "Noto Sans KR";
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(3) .sns p {
    font: 12.8px/1 "Noto Sans KR";
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(3) .sns::-webkit-scrollbar {
    width: 7px;
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(3) .snsGoBtn {
    font: 14.4px/1 "Noto Sans KR";
    margin-top: 15px;
  }
}
@media screen and (max-width: 639px) {
  #promotion {
    height: auto;
  }
  #promotion .promotionContainer {
    height: 900px;
    padding: 50px 5vw 50px;
  }
  #promotion .promotionContainer .circleText {
    width: 400px;
    height: 400px;
    position: absolute;
    z-index: -1;
    top: -90px;
    left: -110px;
    animation: rotateImage 10s linear infinite;
    transform-origin: 50% 50%;
    opacity: 0.5;
  }
  @keyframes rotateImage {
    100% {
      transform: rotate(360deg);
    }
  }
  #promotion .promotionContainer .promotionWrap {
    height: auto;
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(1) {
    flex: 1.5;
    order: 2;
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(1) .top {
    flex: 1;
    width: 100%;
    height: 100%;
    margin-top: 0px;
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(1) .top video {
    width: 100%;
    height: 100%;
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(1) .down .downLeft h3 {
    font: 16.8px/1 "Noto Sans KR";
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(1) .down .downLeft h2 {
    font: bold 16.8px/1 "Noto Sans KR";
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(1) .down .downRight {
    font: 17px/1 "Noto Sans KR";
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(2) {
    order: 1;
    flex: 0.35;
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(2) h4 {
    font: bold 49px/1 "Noto Sans KR";
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(3) {
    flex: 1;
    order: 3;
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(3) .sns {
    width: 100%;
    height: 90%;
    padding-right: 50px;
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(3) .sns h3 {
    font: bold 16.8px/1 "Noto Sans KR";
    margin-bottom: 15px;
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(3) .sns h4 {
    font: 12.6px/1.5 "Noto Sans KR";
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(3) .sns p {
    font: 11.2px/1 "Noto Sans KR";
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(3) .sns::-webkit-scrollbar {
    width: 5.5px;
  }
  #promotion .promotionContainer .promotionWrap:nth-of-type(3) .snsGoBtn {
    margin-left: 0;
    font: 12.6px/1 "Noto Sans KR";
    margin-top: 15px;
  }
}
#museum {
  width: 100vw;
  height: 700px;
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
  display: flex;
  overflow: hidden;
}
#museum .bgLeft {
  width: 50%;
  height: 100%;
  background-image: url("../img/smartHome1.png");
  background-repeat: no-repeat;
  background-size: cover;
}
#museum .bgLeft .leftTxt {
  height: 100%;
  padding: 10px;
  margin-left: 5vw;
  position: relative;
  top: 0%;
  transform: translateY(50%);
  font: 40px/1 "Noto Sans KR";
  color: transparent;
  text-align: center;
  -webkit-text-stroke: 1px #eee;
  white-space: pre-wrap;
  text-orientation: sideways;
  transform: rotate(180deg);
  writing-mode: vertical-rl;
  word-spacing: 5px;
}
#museum .bgRight {
  width: 50%;
  height: 100%;
  background: #4881c2;
}
#museum .bgRight .rightTxt {
  height: 100%;
  float: right;
  color: transparent;
  position: relative;
  text-align: center;
  top: 0%;
  transform: translateY(50%);
  font: 40px/1 "Noto Sans KR";
  -webkit-text-stroke: 1px #eee;
  margin-right: 5vw;
  padding: 10px;
  text-orientation: sideways;
  transform: rotate(180deg);
  writing-mode: vertical-rl;
  white-space: pre-wrap;
  word-spacing: 5px;
}
#museum .container {
  max-width: 100%;
  height: 500px;
  margin: 0 auto;
  padding: 120px 15vw 96px;
  position: absolute;
  z-index: 99;
}
#museum .swiper-container {
  width: 100%;
  height: 500px;
  position: static;
  overflow: hidden;
}
#museum .swiper-container .swiper-wrapper .swiper-slide {
  text-align: center;
  width: 440px;
  height: 440px;
  font-size: 18px;
  background: rgb(255, 255, 255);
  border-radius: 50%;
  background: transparent;
  border: 2px solid white;
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
  text-align: left;
  position: relative;
  padding: 80px 100px;
  text-align: justify;
  word-break: break-all;
}
#museum .swiper-container .swiper-wrapper .swiper-slide:hover {
  background: rgba(0, 0, 0, 0.5);
  border: none;
}
#museum .swiper-container .swiper-wrapper .swiper-slide h3 {
  position: relative;
  font: 16px/1 "Noto Sans KR";
  color: #eee;
  margin-bottom: 35px;
  z-index: 1;
}
#museum .swiper-container .swiper-wrapper .swiper-slide h2 {
  position: relative;
  font: bold 24px/1 "Noto Sans KR";
  color: #eee;
  z-index: 1;
  margin-bottom: 15px;
}
#museum .swiper-container .swiper-wrapper .swiper-slide p {
  position: relative;
  font: 18px/1.5 "Noto Sans KR";
  color: #eee;
  z-index: 1;
  margin-bottom: 40px;
}
#museum .swiper-container .swiper-button-prev {
  position: absolute;
  top: 75%;
  left: 200px;
  width: 26px;
  height: 26px;
  transform: translateY(-200%);
  margin-top: 0px;
}
#museum .swiper-container .swiper-button-next {
  position: absolute;
  top: 75%;
  right: 200px;
  width: 26px;
  height: 26px;
  transform: translateY(-200%);
  margin-top: 0px;
}

@media screen and (max-width: 1023px) {
  #sns {
    width: 100vw;
    height: 600px;
    background-position: center;
    background-repeat: no-repeat;
    background-size: cover;
    display: flex;
  }
  #sns .bgLeft {
    width: 50%;
    height: 100%;
    background-image: url("../img/smartHome1.png");
    background-repeat: no-repeat;
    background-size: cover;
  }
  #sns .bgLeft .leftTxt {
    height: 100%;
    padding: 10px;
    margin-left: 5vw;
    position: relative;
    top: 0%;
    transform: translateY(50%);
    font: 40px/1 "Noto Sans KR";
    color: transparent;
    text-align: center;
    -webkit-text-stroke: 1px #eee;
    white-space: pre-wrap;
    text-orientation: sideways;
    transform: rotate(180deg);
    writing-mode: vertical-rl;
    word-spacing: 5px;
  }
  #sns .bgRight {
    width: 50%;
    height: 100%;
    background: #4881c2;
  }
  #sns .bgRight .rightTxt {
    height: 100%;
    float: right;
    color: transparent;
    position: relative;
    text-align: center;
    top: 0%;
    transform: translateY(50%);
    font: 40px/1 "Noto Sans KR";
    -webkit-text-stroke: 1px #eee;
    margin-right: 5vw;
    padding: 10px;
    text-orientation: sideways;
    transform: rotate(180deg);
    writing-mode: vertical-rl;
    white-space: pre-wrap;
    word-spacing: 5px;
    display: none;
  }
  #sns .container {
    max-width: 100%;
    height: 600px;
    margin: 0 auto;
    padding: 120px 10vw 96px;
    position: absolute;
    z-index: 99;
  }
  #sns .swiper-container {
    width: 100%;
    height: 400px;
    position: static;
  }
  #sns .swiper-container .swiper-wrapper .swiper-slide {
    text-align: center;
    width: 320px;
    height: 320px;
    font-size: 18px;
    background: rgb(255, 255, 255);
    border-radius: 50%;
    background: transparent;
    border: 2px solid white;
    background-position: center;
    background-repeat: no-repeat;
    background-size: cover;
    text-align: left;
    position: relative;
    padding: 80px 64px;
  }
  #sns .swiper-container .swiper-wrapper .swiper-slide h3 {
    position: relative;
    font: 12.8px/1 "Noto Sans KR";
    color: #eee;
    margin-bottom: 25px;
    z-index: 1;
  }
  #sns .swiper-container .swiper-wrapper .swiper-slide h2 {
    position: relative;
    font: bold 19.2px/1 "Noto Sans KR";
    color: #eee;
    z-index: 1;
    margin-bottom: 25px;
  }
  #sns .swiper-container .swiper-wrapper .swiper-slide p {
    position: relative;
    font: 14.4px/1.5 "Noto Sans KR";
    color: #eee;
    z-index: 1;
    margin-bottom: 0px;
    text-align: justify;
    word-break: break-all;
  }
  #sns .swiper-container .swiper-button-prev {
    position: absolute;
    top: 53%;
    left: 50px;
    width: 24px;
    height: 24px;
    transform: translateY(-200%);
    margin-top: 0px;
  }
  #sns .swiper-container .swiper-button-next {
    position: absolute;
    top: 53%;
    right: 50px;
    width: 24px;
    height: 24px;
    transform: translateY(-200%);
    margin-top: 0px;
  }
}
@media screen and (max-width: 639px) {
  #sns {
    width: 100vw;
    height: 600px;
    background-position: center;
    background-repeat: no-repeat;
    background-size: cover;
    display: flex;
  }
  #sns .bgLeft {
    width: 50%;
    height: 100%;
  }
  #sns .bgRight {
    width: 50%;
    height: 100%;
    float: right;
  }
  #sns .container {
    max-width: 100%;
    height: 600px;
    margin: 0 auto;
    padding: 120px 10vw 96px;
    position: absolute;
    z-index: 99;
  }
  #sns .swiper-container {
    width: 80%;
    height: 400px;
    position: static;
  }
  #sns .swiper-container .swiper-wrapper .swiper-slide {
    text-align: center;
    width: 110px;
    height: 300px;
    font-size: 18px;
    backdrop-filter: brightness(0.4);
    border-radius: 50%;
    background: transparent;
    border: none;
    background-position: center;
    background-repeat: no-repeat;
    background-size: cover;
    text-align: left;
    position: relative;
    padding: 70px 56px;
  }
  #sns .swiper-container .swiper-wrapper .swiper-slide h3 {
    position: relative;
    font: 11.2px/1 "Noto Sans KR";
    color: #eee;
    margin-bottom: 25px;
    z-index: 1;
  }
  #sns .swiper-container .swiper-wrapper .swiper-slide h2 {
    position: relative;
    font: bold 16.8px/1 "Noto Sans KR";
    color: #eee;
    z-index: 1;
    margin-bottom: 25px;
  }
  #sns .swiper-container .swiper-wrapper .swiper-slide p {
    position: relative;
    font: 12.6px/1.5 "Noto Sans KR";
    color: #eee;
    z-index: 1;
    margin-bottom: 100px;
  }
  #sns .swiper-container .swiper-button-prev {
    position: absolute;
    top: 50%;
    left: 30px;
    width: 24px;
    height: 24px;
    transform: translateY(-200%);
    margin-top: 0px;
  }
  #sns .swiper-container .swiper-button-next {
    position: absolute;
    top: 50%;
    right: 30px;
    width: 24px;
    height: 24px;
    transform: translateY(-200%);
    margin-top: 0px;
  }
}
#showRoom {
  width: 100vw;
  height: 750px;
  background: #f9f9f9;
  padding: 96px 10vw 96px;
  display: flex;
}
#showRoom .showRoomContainer {
  width: 100%;
  height: 100%;
  background: yellow;
  display: flex;
}
#showRoom .showRoomContainer .showRoomWrap {
  width: 50%;
  height: 100%;
  display: flex;
  flex-wrap: wrap;
}
#showRoom .showRoomContainer .showRoomWrap:nth-of-type(1) {
  flex: 1;
  background: blue;
}
#showRoom .showRoomContainer .showRoomWrap:nth-of-type(2) {
  flex: 2;
  background: rgb(25, 179, 102);
}

#notice {
  width: 100vw;
  height: 750px;
  background: white;
  padding: 0px 10vw 0px;
}
#notice .noticeContainer {
  width: 100%;
  height: 100%;
  display: flex;
  padding: 96px 0px 96px;
}
#notice .noticeContainer .noticeWrap {
  width: 100%;
  height: 100%;
}
#notice .noticeContainer .noticeWrap:nth-of-type(1) {
  flex: 0.5;
  width: 100%;
  height: 100%;
  background: white;
  padding-top: 60px;
}
#notice .noticeContainer .noticeWrap:nth-of-type(1) h4 {
  font: bold 70px/1 "Noto Sans KR";
  color: #171717;
  margin-bottom: 70px;
}
#notice .noticeContainer .noticeWrap:nth-of-type(1) .goBtn {
  font: 18px/1 "Noto Sans KR";
  color: #171717;
  margin-bottom: 150px;
  cursor: pointer;
}
#notice .noticeContainer .noticeWrap:nth-of-type(1) .iconWrap {
  font: 26px/1 "Noto Sans KR";
  color: #171717;
  display: flex;
  gap: 30px;
}
#notice .noticeContainer .noticeWrap:nth-of-type(1) .iconWrap i {
  cursor: pointer;
}
#notice .noticeContainer .noticeWrap:nth-of-type(1) .iconWrap span:nth-of-type(1):hover {
  color: rgb(16, 16, 158);
}
#notice .noticeContainer .noticeWrap:nth-of-type(1) .iconWrap span:nth-of-type(2):hover {
  color: rgb(213, 5, 32);
}
#notice .noticeContainer .noticeWrap:nth-of-type(1) .iconWrap span:nth-of-type(3):hover {
  color: rgb(208, 2, 136);
}
#notice .noticeContainer .noticeWrap:nth-of-type(1) .iconWrap span:nth-of-type(4):hover {
  color: rgb(8, 113, 5);
}
#notice .noticeContainer .noticeWrap:nth-of-type(2) {
  flex: 1;
  width: 100%;
  height: 100%;
  display: flex;
  flex-wrap: wrap;
}
#notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap {
  display: flex;
  width: 50%;
  height: 50%;
  background: white;
  display: flex;
  flex-direction: column;
  padding: 50px;
  padding-top: 60px;
  border-left: 1px solid #e9e9e9;
}
#notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .topic {
  width: 100%;
  font: 16px/1 "Noto Sans KR";
  color: #1188bb;
  margin-bottom: 20px;
}
#notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .topic p {
  cursor: pointer;
}
#notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .titleWrap {
  width: 100%;
  display: flex;
  flex-wrap: nowrap;
  display: flex;
  justify-content: space-between;
  margin-bottom: 20px;
  cursor: pointer;
}
#notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .titleWrap h2 {
  width: 70%;
  font: bold 24px/1.5 "Noto Sans KR";
  color: #171717;
  text-align: justify;
  word-break: break-all;
}
#notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .titleWrap h2:hover {
  text-decoration-line: underline;
  text-decoration-color: #171717;
  text-decoration-thickness: 2px;
  text-underline-offset: 5px;
  text-underline-position: under;
}
#notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .titleWrap p {
  font: 16px/2.5 "Noto Sans KR";
  color: #171717;
}
#notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .content {
  width: 100%;
  margin-bottom: 20px;
  text-align: justify;
  word-break: break-all;
}
#notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .content p {
  font: 18px/1.6 "Noto Sans KR";
  color: #171717;
  cursor: pointer;
}

@media screen and (max-width: 1023px) {
  #notice {
    height: 744px;
    padding: 0px 5vw 0px;
  }
  #notice .noticeContainer {
    padding: 96px 0px 96px;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(1) {
    flex: 0.55;
    padding-top: 30px;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(1) h4 {
    font: bold 56px/1 "Noto Sans KR";
    margin-bottom: 50px;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(1) .goBtn {
    font: 14.4px/1 "Noto Sans KR";
    margin-bottom: 48px;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(1) .iconWrap {
    font: 24px/1 "Noto Sans KR";
    gap: 20px;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(2) {
    flex: 1;
    display: block;
    flex-direction: column;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap {
    width: 100%;
    height: auto;
    flex-direction: column;
    padding: 10px;
    padding-top: 30px;
    border-left: 1px solid #e9e9e9;
    padding-left: 40px;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .topic {
    width: 100%;
    font: 12.8px/1 "Noto Sans KR";
    color: #1188bb;
    margin-bottom: 20px;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .titleWrap {
    width: 100%;
    margin-bottom: 40px;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .titleWrap h2 {
    font: bold 19.2px/1.5 "Noto Sans KR";
    color: #171717;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .titleWrap p {
    font: 12.8px/2.5 "Noto Sans KR";
    color: #171717;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .content {
    width: 100%;
    margin-bottom: 20px;
    text-align: justify;
    word-break: break-all;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .content p {
    font: 14.4px/1.6 "Noto Sans KR";
    color: #171717;
  }
}
@media screen and (max-width: 639px) {
  #notice {
    height: 744px;
    padding: 0px 5vw 0px;
  }
  #notice .noticeContainer {
    padding: 35px 0px 35px;
    display: block;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(1) {
    flex: 0.55;
    height: auto;
    padding-top: 0px;
    background: blue;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(1) h4 {
    width: 50%;
    font: bold 49px/1 "Noto Sans KR";
    margin-bottom: 0px;
    float: left;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(1) .goBtn {
    width: 50%;
    font: 12.6px/4 "Noto Sans KR";
    margin-bottom: 20px;
    float: right;
    text-align: end;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(1) .iconWrap {
    display: none;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap {
    padding: 0px;
    padding-top: 30px;
    border-left: none;
    padding-left: 0px;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .topic {
    font: 11.2px/1 "Noto Sans KR";
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .titleWrap {
    margin-bottom: 20px;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .titleWrap h2 {
    font: bold 16.8px/1.8 "Noto Sans KR";
    color: #171717;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .titleWrap p {
    font: 11.2px/2.5 "Noto Sans KR";
    color: #171717;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .content {
    width: 100%;
    margin-bottom: 20px;
    text-align: justify;
    word-break: break-all;
  }
  #notice .noticeContainer .noticeWrap:nth-of-type(2) .contentWrap .content p {
    font: 12.6px/1.5 "Noto Sans KR";
    color: #171717;
  }
}
.location {
  width: 100vw;
  height: 100vh;
}
.location .subVisual {
  width: 100%;
  height: 480px;
  position: relative;
  overflow: hidden;
}
.location .subVisual video {
  object-fit: contain;
  object-position: 0vw -28vw;
}
.location .subVisual .background {
  width: 50%;
  height: 80px;
  background: white;
  position: absolute;
  bottom: 0;
  left: 0;
}
.location .titContainer {
  width: 100%;
  height: 300px;
  padding: 150px 15vw 246px;
}
.location .titContainer h1 {
  text-align: left;
  font: bold 70px/1 "Noto Sans KR";
  color: #333;
  margin-top: 20px;
  margin-bottom: 96px;
}
.location #map {
  width: 100%;
  height: 600px;
  margin: 0px auto;
  position: relative;
}
.location .storeListContainer {
  width: 100%;
  height: 600px;
  display: flex;
  flex-wrap: wrap;
}
.location .storeListContainer .left {
  width: 35%;
  height: 100%;
  background: #fff;
}
.location .storeListContainer .left h2 {
  margin-top: 40px;
  font: bold 51px/1 "Noto Sans KR";
  color: #171717;
  margin-bottom: 50px;
}
.location .storeListContainer .left p {
  font: 18px/1.5 "Noto Sans KR";
  color: #171717;
}
.location .rightContainer {
  width: 65%;
  height: 100%;
  display: flex;
  flex-wrap: wrap;
  background: #fff;
}
.location .rightContainer .list {
  width: 50%;
  height: 100%;
  display: flex;
  flex-wrap: wrap;
}
.location .rightContainer .list:nth-of-type(1) {
  width: 50%;
  height: 50%;
  background: #fff;
  display: flex;
  flex-direction: column;
  border-left: 1px solid #e9e9e9;
}
.location .rightContainer .list:nth-of-type(1):hover {
  background: #e0e1fa;
}
.location .rightContainer .list:nth-of-type(1).on {
  background: #c4c7fc;
}
.location .rightContainer .list:nth-of-type(1) .storeName {
  flex: 0.5;
  text-align: left;
  padding: 32px;
  margin-top: 5px;
}
.location .rightContainer .list:nth-of-type(1) .storeName .tit {
  font: bold 51px/1 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(1) .storeAddress {
  width: 100%;
  height: auto;
  margin-bottom: 10px;
  padding-left: 20px;
}
.location .rightContainer .list:nth-of-type(1) .storeAddress p {
  font: 16px/1 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(1) .storeOpen {
  width: 100%;
  height: auto;
  margin-bottom: 10px;
  padding-left: 20px;
}
.location .rightContainer .list:nth-of-type(1) .storeOpen p {
  font: 16px/1.8 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(1) .storeOpen p span {
  font: bold 16px/1.8 "Noto Sans KR";
}
.location .rightContainer .list:nth-of-type(1) .storeOpen h4 {
  font: 16px/1.8 "Noto Sans KR";
  color: #3500ea;
  padding-left: 2em;
}
.location .rightContainer .list:nth-of-type(1) .storePhone {
  width: 100%;
  height: auto;
  margin-bottom: 10px;
  padding-left: 20px;
}
.location .rightContainer .list:nth-of-type(1) .storePhone p {
  font: 16px/1 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(1) .storeSite {
  width: 100%;
  height: auto;
  padding-left: 20px;
}
.location .rightContainer .list:nth-of-type(1) .storeSite p {
  font: 16px/1 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(2) {
  width: 50%;
  height: 50%;
  background: #fff;
  display: flex;
  flex-direction: column;
  border-left: 1px solid #e9e9e9;
  text-align: left;
}
.location .rightContainer .list:nth-of-type(2):hover {
  background: #e0e1fa;
}
.location .rightContainer .list:nth-of-type(2).on {
  background: #c4c7fc;
}
.location .rightContainer .list:nth-of-type(2) .storeName {
  flex: 0.5;
  text-align: left;
  padding: 32px;
  margin-top: 5px;
}
.location .rightContainer .list:nth-of-type(2) .storeName .tit {
  font: bold 51px/1 "Noto Sans KR";
  background: repeating-linear-gradient(45deg, #3500ea, #3500ea 0.5px, #e7e8fc 0.5px, #e7e8fc 1.2px);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
  background-clip: text;
  color: transparent;
}
.location .rightContainer .list:nth-of-type(2) .storeAddress {
  width: 100%;
  height: auto;
  margin-bottom: 10px;
  padding-left: 20px;
}
.location .rightContainer .list:nth-of-type(2) .storeAddress p {
  font: 16px/1 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(2) .storeOpen {
  width: 100%;
  height: auto;
  margin-bottom: 10px;
  padding-left: 20px;
}
.location .rightContainer .list:nth-of-type(2) .storeOpen p {
  font: 16px/1.8 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(2) .storeOpen p span {
  font: bold 16px/1.8 "Noto Sans KR";
}
.location .rightContainer .list:nth-of-type(2) .storeOpen h4 {
  font: 16px/1.8 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(2) .storePhone {
  width: 100%;
  height: auto;
  margin-bottom: 10px;
  padding-left: 20px;
}
.location .rightContainer .list:nth-of-type(2) .storePhone p {
  font: 16px/1 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(2) .storeSite {
  width: 100%;
  height: auto;
  padding-left: 20px;
}
.location .rightContainer .list:nth-of-type(2) .storeSite p {
  font: 16px/1 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(3) {
  width: 50%;
  height: 50%;
  background: #fff;
  display: flex;
  flex-direction: column;
  border-left: 1px solid #e9e9e9;
  text-align: left;
}
.location .rightContainer .list:nth-of-type(3):hover {
  background: #e0e1fa;
}
.location .rightContainer .list:nth-of-type(3).on {
  background: #c4c7fc;
}
.location .rightContainer .list:nth-of-type(3) .storeName {
  flex: 0.5;
  text-align: left;
  padding: 32px;
  margin-top: 5px;
}
.location .rightContainer .list:nth-of-type(3) .storeName .tit {
  font: bold 51px/1 "Noto Sans KR";
  background: repeating-linear-gradient(45deg, #3500ea, #3500ea 0.5px, #e7e8fc 0.5px, #e7e8fc 1.2px);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
  background-clip: text;
  color: transparent;
}
.location .rightContainer .list:nth-of-type(3) .storeAddress {
  width: 100%;
  height: auto;
  margin-bottom: 10px;
  padding-left: 20px;
}
.location .rightContainer .list:nth-of-type(3) .storeAddress p {
  font: 16px/1 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(3) .storeOpen {
  width: 100%;
  height: auto;
  margin-bottom: 10px;
  padding-left: 20px;
}
.location .rightContainer .list:nth-of-type(3) .storeOpen p {
  font: 16px/1.8 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(3) .storeOpen p span {
  font: bold 16px/1.8 "Noto Sans KR";
}
.location .rightContainer .list:nth-of-type(3) .storeOpen h4 {
  font: 16px/1.8 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(3) .storePhone {
  width: 100%;
  height: auto;
  margin-bottom: 10px;
  padding-left: 20px;
}
.location .rightContainer .list:nth-of-type(3) .storePhone p {
  font: 16px/1 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(3) .storeSite {
  width: 100%;
  height: auto;
  padding-left: 20px;
}
.location .rightContainer .list:nth-of-type(3) .storeSite p {
  font: 16px/1 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(4) {
  width: 50%;
  height: 50%;
  background: #fff;
  display: flex;
  flex-direction: column;
  border-left: 1px solid #e9e9e9;
  text-align: left;
}
.location .rightContainer .list:nth-of-type(4):hover {
  background: #e0e1fa;
}
.location .rightContainer .list:nth-of-type(4).on {
  background: #c4c7fc;
}
.location .rightContainer .list:nth-of-type(4) .storeName {
  flex: 0.5;
  text-align: left;
  padding: 32px;
  margin-top: 5px;
}
.location .rightContainer .list:nth-of-type(4) .storeName .tit {
  font: bold 51px/1 "Noto Sans KR";
  background: repeating-linear-gradient(45deg, #3500ea, #3500ea 0.5px, #e7e8fc 0.5px, #e7e8fc 1.2px);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
  background-clip: text;
  color: transparent;
}
.location .rightContainer .list:nth-of-type(4) .storeAddress {
  width: 100%;
  height: auto;
  margin-bottom: 10px;
  padding-left: 20px;
}
.location .rightContainer .list:nth-of-type(4) .storeAddress p {
  font: 16px/1 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(4) .storeOpen {
  width: 100%;
  height: auto;
  margin-bottom: 10px;
  padding-left: 20px;
}
.location .rightContainer .list:nth-of-type(4) .storeOpen p {
  font: 16px/1.8 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(4) .storeOpen p span {
  font: bold 16px/1.8 "Noto Sans KR";
}
.location .rightContainer .list:nth-of-type(4) .storeOpen h4 {
  font: 16px/1.8 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(4) .storePhone {
  width: 100%;
  height: auto;
  margin-bottom: 10px;
  padding-left: 20px;
}
.location .rightContainer .list:nth-of-type(4) .storePhone p {
  font: 16px/1 "Noto Sans KR";
  color: #3500ea;
}
.location .rightContainer .list:nth-of-type(4) .storeSite {
  width: 100%;
  height: auto;
  padding-left: 20px;
}
.location .rightContainer .list:nth-of-type(4) .storeSite p {
  font: 16px/1 "Noto Sans KR";
  color: #3500ea;
}
.location .contactContainer {
  width: 100%;
  height: 500px;
}
.location .contactContainer .contact {
  width: 100%;
  height: 100%;
  float: left;
  border-top: 1px solid #e9e9e9;
}
.location .contactContainer .contact:nth-of-type(1) {
  width: 35%;
  height: 100%;
}
.location .contactContainer .contact:nth-of-type(1) h2 {
  margin-top: 40px;
  font: bold 51px/1 "Noto Sans KR";
  color: #171717;
  margin-bottom: 50px;
}
.location .contactContainer .contact:nth-of-type(2) {
  width: 32.5%;
  height: 100%;
  border-left: 1px solid #e9e9e9;
  padding: 43px 1vw 43px;
  font: 16px/1 "Noto Sans KR";
  color: #3500ea;
  margin-bottom: 150px;
  background: #e0e1fa;
}
.location .contactContainer .contact:nth-of-type(2) label {
  width: 100%;
}
.location .contactContainer .contact:nth-of-type(2) input {
  display: block;
  width: 100%;
  height: 25px;
  margin-top: 10px;
  margin-bottom: 30px;
  padding: 5px;
  background: #fafaff;
  border: none;
  font: 16px/1 "Noto Sans KR";
  color: #3500ea;
}
.location .contactContainer .contact:nth-of-type(2) textarea {
  display: block;
  width: 100%;
  height: 100px;
  margin-top: 10px;
  margin-bottom: 30px;
  background: #fafaff;
  padding: 1px;
  border: none;
  font: 16px/1 "Noto Sans KR";
  color: #3500ea;
  resize: none;
}
.location .contactContainer .contact:nth-of-type(2) .submitBtn {
  width: 150px;
  height: 41px;
  color: #3500ea;
  font: 16px/1 "Noto Sans KR";
}
.location .contactContainer .contact:nth-of-type(3) {
  width: 32.5%;
  height: 100%;
  border-left: 1px solid #e9e9e9;
  padding: 43px 1vw 43px;
  font: 16px/1 "Noto Sans KR";
  color: #3500ea;
  margin-bottom: 150px;
  background: #e0e1fa;
  font: 40px/1 "Noto Sans KR";
}
.location .contactContainer .contact:nth-of-type(3) .svgBox {
  width: 100%;
  height: 100%;
  border: 1px solid red;
  display: flex;
  align-items: center;
  justify-content: center;
}
.location .contactContainer .contact:nth-of-type(3) .svgBox svg path {
  fill: rgba(0, 0, 0, 0.3);
  stroke: #000;
  stroke-width: 10;
  stroke-dasharray: 2730;
  stroke-dashoffset: 2730;
  stroke-linecap: round;
  transition: stroke-dashoffset 1s;
}
.location .contactContainer .contact:nth-of-type(3) .svgBox:hover svg path {
  stroke-dashoffset: 0;
}

.members {
  width: 100vw;
  height: 100vh;
}
.members .subVisual {
  width: 100%;
  height: 480px;
  position: relative;
  overflow: hidden;
}
.members .subVisual video {
  object-fit: contain;
  object-position: 0vw -20vw;
}
.members .subVisual .background {
  width: 50%;
  height: 80px;
  background: white;
  position: absolute;
  bottom: 0;
  left: 0;
}
.members .titContainer {
  width: 100%;
  height: auto;
  padding: 150px 0vw 250px;
  margin-bottom: 96px;
  display: flex;
  flex-direction: column;
  justify-content: center;
}
.members .titContainer p {
  position: relative;
  top: 3vw;
  font: 20px/1 "Noto Sans KR";
  color: #333;
  text-align: center;
  z-index: 99;
}
.members .titContainer img {
  top: 2vw;
  width: 100px;
  margin: 0px auto;
  height: 100px;
  position: relative;
  z-index: 99;
}
.members .titContainer h1 {
  text-align: center;
  font: bold 550px/1 "Noto Sans KR";
  color: #010001;
  margin-bottom: 96px;
  margin: 0px auto;
  z-index: 99;
  position: relative;
  animation: textBig 3s ease-in-out;
  animation-fill-mode: forwards;
  animation-delay: 1s;
}
@keyframes textBig {
  0% {
    transform: scale(1);
  }
  100% {
    transform: scale(0.9);
  }
}
.members html {
  min-height: 100vh;
}
.members section {
  position: absolute;
  top: 0;
  left: 0;
  width: 100%;
  height: 165vh;
  margin-top: 480px;
  padding: 0px 0vw 0px;
  display: grid;
  grid-template-columns: repeat(4, 1fr);
  grid-template-rows: repeat(4, 1fr);
}
.members .box1 {
  z-index: 1;
  position: relative;
}
.members .box1:nth-of-type(1) {
  grid-column: 1/span 1;
  grid-row: 1/span 1;
  background-color: #fedc01;
  transition: clip-path 1s linear;
  clip-path: circle(0px at center);
}
.members .box1:nth-of-type(2) {
  grid-column: 2/span 1;
  grid-row: 1/span 1;
  background-color: #fedc01;
  transition: clip-path 1s linear;
  clip-path: circle(0px at center);
}
.members section .box1:nth-child(3) {
  grid-column: 3/span 1;
  grid-row: 1/span 1;
  background-color: #fedc01;
  transition: clip-path 1s linear;
  clip-path: circle(0px at center);
}
.members section .box:nth-child(4) {
  grid-column: 4/span 1;
  grid-row: 1/span 1;
  background-color: #fedc01;
  transition: clip-path 1s linear;
  clip-path: circle(0px at center);
}
.members .box1:nth-of-type(5) {
  grid-column: 1/span 1;
  grid-row: 2/span 1;
  background-color: #fedc01;
  transition: clip-path 1s linear;
  clip-path: circle(0px at center);
}
.members .box1:nth-of-type(6) {
  grid-column: 2/span 1;
  grid-row: 2/span 1;
  background-color: #fedc01;
  transition: clip-path 1s linear;
  clip-path: circle(0px at center);
}
.members section .box1:nth-child(7) {
  grid-column: 3/span 1;
  grid-row: 2/span 1;
  background-color: #fedc01;
  transition: clip-path 1s linear;
  clip-path: circle(0px at center);
}
.members section .box:nth-child(8) {
  grid-column: 4/span 1;
  grid-row: 2/span 1;
  background-color: #fedc01;
  transition: clip-path 1s linear;
  clip-path: circle(0px at center);
}
.members .box1:nth-of-type(9) {
  grid-column: 1/span 1;
  grid-row: 3/span 1;
  background-color: #fedc01;
  transition: clip-path 1s linear;
  clip-path: circle(0px at center);
}
.members .box1:nth-of-type(10) {
  grid-column: 2/span 1;
  grid-row: 3/span 1;
  background-color: #fedc01;
  transition: clip-path 1s linear;
  clip-path: circle(0px at center);
}
.members section .box1:nth-child(11) {
  grid-column: 3/span 1;
  grid-row: 3/span 1;
  background-color: #fedc01;
  transition: clip-path 1s linear;
  clip-path: circle(0px at center);
}
.members section .box:nth-child(12) {
  grid-column: 4/span 1;
  grid-row: 3/span 1;
  background-color: #fedc01;
  transition: clip-path 1s linear;
  clip-path: circle(0px at center);
}
.members .box1:nth-of-type(13) {
  grid-column: 1/span 1;
  grid-row: 4/span 1;
  background-color: #fedc01;
  transition: clip-path 1s linear;
  clip-path: circle(0px at center);
}
.members .box1:nth-of-type(14) {
  grid-column: 2/span 1;
  grid-row: 4/span 1;
  background-color: #fedc01;
  transition: clip-path 1s linear;
  clip-path: circle(0px at center);
}
.members section .box1:nth-child(15) {
  grid-column: 3/span 1;
  grid-row: 4/span 1;
  background-color: #fedc01;
  transition: clip-path 1s linear;
  clip-path: circle(0px at center);
}
.members section .box:nth-child(16) {
  grid-column: 4/span 1;
  grid-row: 4/span 1;
  background-color: #fedc01;
  transition: clip-path 1s linear;
  clip-path: circle(0px at center);
}
.members .middleText {
  width: 100%;
  height: 300px;
  font: 25px/1.4 "Noto Sans KR";
  color: #333;
  text-align: center;
  padding: 150px 15vw 0px;
}
.members .middleText p {
  position: relative;
  z-index: 2;
  opacity: 0;
  animation: appearContents 5s ease-in-out;
  animation-fill-mode: forwards;
  animation-delay: 5s;
  transition: opacity 0.5s;
}
@keyframes appearContents {
  0% {
    opacity: 0;
  }
  100% {
    opacity: 1;
  }
}
.members .slider {
  width: 100%;
  height: 584px;
  margin: 0 auto;
  margin-top: 20px;
  background: tomato;
  overflow: hidden;
  position: relative;
  z-index: 99;
  top: 0;
  left: 0;
  margin-bottom: 100px;
}
.members .slide {
  height: 600px;
  color: white;
  font-size: 50px;
  width: 100%;
  height: 100%;
  display: none;
  line-height: 300px;
  display: inline-block;
}
.members .slide:nth-of-type(4) {
  width: 100%;
  height: 100%;
  background: #ff9dd1;
  padding: 40px;
}
.members .slide:nth-of-type(4) .slideBox {
  width: 100%;
  height: 100%;
  display: flex;
}
.members .slide:nth-of-type(4) .slideBox .left {
  flex: 1;
  width: 100%;
  height: 100%;
  background-image: url(../img/memberSlider1.png);
  background-size: contain;
  background-repeat: no-repeat;
  background-position: right;
}
.members .slide:nth-of-type(4) .slideBox .right {
  flex: 1.7;
  width: 100%;
  height: 100%;
  text-align: left;
  padding: 25px 0px 0px 70px;
}
.members .slide:nth-of-type(4) .slideBox .right h3 {
  font: 14px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 15px;
}
.members .slide:nth-of-type(4) .slideBox .right h2 {
  font: bold 36px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 20px;
}
.members .slide:nth-of-type(4) .slideBox .right p {
  font: 16px/1.8 "Noto Sans KR";
  color: #333;
  padding-right: 20vw;
}
.members .slide:nth-of-type(4) .slideBox .right p span {
  font: 25px/1 "Noto Sans KR";
  color: #333;
}
.members .slide:nth-of-type(2) {
  width: 100%;
  height: 100%;
  background: #67e9c3;
  padding: 40px;
}
.members .slide:nth-of-type(2) .slideBox {
  width: 100%;
  height: 100%;
  display: flex;
}
.members .slide:nth-of-type(2) .slideBox .left {
  flex: 1;
  width: 100%;
  height: 100%;
  background-image: url(../img/memberSlider2.png);
  background-size: contain;
  background-repeat: no-repeat;
  background-position: right;
}
.members .slide:nth-of-type(2) .slideBox .right {
  flex: 1.7;
  width: 100%;
  height: 100%;
  text-align: left;
  padding: 25px 0px 0px 70px;
}
.members .slide:nth-of-type(2) .slideBox .right h3 {
  font: 14px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 15px;
}
.members .slide:nth-of-type(2) .slideBox .right h2 {
  font: bold 36px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 20px;
}
.members .slide:nth-of-type(2) .slideBox .right p {
  font: 16px/1.8 "Noto Sans KR";
  color: #333;
  padding-right: 20vw;
}
.members .slide:nth-of-type(2) .slideBox .right p span {
  font: 25px/1 "Noto Sans KR";
  color: #333;
}
.members .slide:nth-of-type(3) {
  width: 100%;
  height: 100%;
  background: #66c2f6;
  padding: 40px;
}
.members .slide:nth-of-type(3) .slideBox {
  width: 100%;
  height: 100%;
  display: flex;
}
.members .slide:nth-of-type(3) .slideBox .left {
  flex: 1;
  width: 100%;
  height: 100%;
  background-image: url(../img/memberSlider3.png);
  background-size: contain;
  background-repeat: no-repeat;
  background-position: right;
}
.members .slide:nth-of-type(3) .slideBox .right {
  flex: 1.7;
  width: 100%;
  height: 100%;
  text-align: left;
  padding: 25px 0px 0px 70px;
}
.members .slide:nth-of-type(3) .slideBox .right h3 {
  font: 14px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 15px;
}
.members .slide:nth-of-type(3) .slideBox .right h2 {
  font: bold 36px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 20px;
}
.members .slide:nth-of-type(3) .slideBox .right p {
  font: 16px/1.8 "Noto Sans KR";
  color: #333;
  padding-right: 20vw;
}
.members .slide:nth-of-type(3) .slideBox .right p span {
  font: 25px/1 "Noto Sans KR";
  color: #333;
}
.members .slide:nth-of-type(1) {
  width: 100%;
  height: 100%;
  background: #fedc01;
  padding: 40px;
}
.members .slide:nth-of-type(1) .slideBox {
  width: 100%;
  height: 100%;
  display: flex;
}
.members .slide:nth-of-type(1) .slideBox .left {
  flex: 1;
  width: 100%;
  height: 100%;
  background-image: url(../img/memberSlider4.png);
  background-size: contain;
  background-repeat: no-repeat;
  background-position: right;
}
.members .slide:nth-of-type(1) .slideBox .right {
  flex: 1.7;
  width: 100%;
  height: 100%;
  text-align: left;
  padding: 25px 0px 0px 70px;
}
.members .slide:nth-of-type(1) .slideBox .right h3 {
  font: 14px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 15px;
}
.members .slide:nth-of-type(1) .slideBox .right h2 {
  font: bold 36px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 20px;
}
.members .slide:nth-of-type(1) .slideBox .right p {
  font: 16px/1.8 "Noto Sans KR";
  color: #333;
  padding-right: 20vw;
}
.members .slide:nth-of-type(1) .slideBox .right p span {
  font: 25px/1 "Noto Sans KR";
  color: #333;
}
.members .slide:nth-of-type(5) {
  width: 100%;
  height: 100%;
  background: #5eda2b;
  padding: 40px;
}
.members .slide:nth-of-type(5) .slideBox {
  width: 100%;
  height: 100%;
  display: flex;
}
.members .slide:nth-of-type(5) .slideBox .left {
  flex: 1;
  width: 100%;
  height: 100%;
  background-image: url(../img/memberSlider5.png);
  background-size: contain;
  background-repeat: no-repeat;
  background-position: right;
}
.members .slide:nth-of-type(5) .slideBox .right {
  flex: 1.7;
  width: 100%;
  height: 100%;
  text-align: left;
  padding: 25px 0px 0px 70px;
}
.members .slide:nth-of-type(5) .slideBox .right h3 {
  font: 14px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 15px;
}
.members .slide:nth-of-type(5) .slideBox .right h2 {
  font: bold 36px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 20px;
}
.members .slide:nth-of-type(5) .slideBox .right p {
  font: 16px/1.8 "Noto Sans KR";
  color: #333;
  padding-right: 20vw;
}
.members .slide:nth-of-type(5) .slideBox .right p span {
  font: 25px/1 "Noto Sans KR";
  color: #333;
}
.members .slide:nth-of-type(6) {
  width: 100%;
  height: 100%;
  background: #f03c69;
  padding: 40px;
}
.members .slide:nth-of-type(6) .slideBox {
  width: 100%;
  height: 100%;
  display: flex;
}
.members .slide:nth-of-type(6) .slideBox .left {
  flex: 1;
  width: 100%;
  height: 100%;
  background-image: url(../img/memberSlider6.png);
  background-size: contain;
  background-repeat: no-repeat;
  background-position: right;
}
.members .slide:nth-of-type(6) .slideBox .right {
  flex: 1.7;
  width: 100%;
  height: 100%;
  text-align: left;
  padding: 25px 0px 0px 70px;
}
.members .slide:nth-of-type(6) .slideBox .right h3 {
  font: 14px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 15px;
}
.members .slide:nth-of-type(6) .slideBox .right h2 {
  font: bold 36px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 20px;
}
.members .slide:nth-of-type(6) .slideBox .right p {
  font: 16px/1.8 "Noto Sans KR";
  color: #333;
  padding-right: 20vw;
}
.members .slide:nth-of-type(6) .slideBox .right p span {
  font: 25px/1 "Noto Sans KR";
  color: #333;
}
.members .slide:nth-of-type(7) {
  width: 100%;
  height: 100%;
  background: #ff9dd1;
  padding: 40px;
}
.members .slide:nth-of-type(7) .slideBox {
  width: 100%;
  height: 100%;
  display: flex;
}
.members .slide:nth-of-type(7) .slideBox .left {
  flex: 1;
  width: 100%;
  height: 100%;
  background-image: url(../img/memberSlider7.png);
  background-size: contain;
  background-repeat: no-repeat;
  background-position: right;
}
.members .slide:nth-of-type(7) .slideBox .right {
  flex: 1.7;
  width: 100%;
  height: 100%;
  text-align: left;
  padding: 25px 0px 0px 70px;
}
.members .slide:nth-of-type(7) .slideBox .right h3 {
  font: 14px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 15px;
}
.members .slide:nth-of-type(7) .slideBox .right h2 {
  font: bold 36px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 20px;
}
.members .slide:nth-of-type(7) .slideBox .right p {
  font: 16px/1.8 "Noto Sans KR";
  color: #333;
  padding-right: 20vw;
}
.members .slide:nth-of-type(7) .slideBox .right p span {
  font: 25px/1 "Noto Sans KR";
  color: #333;
}
.members .slide:nth-of-type(8) {
  width: 100%;
  height: 100%;
  background: #fedc01;
  padding: 40px;
}
.members .slide:nth-of-type(8) .slideBox {
  width: 100%;
  height: 100%;
  display: flex;
}
.members .slide:nth-of-type(8) .slideBox .left {
  flex: 1;
  width: 100%;
  height: 100%;
  background-image: url(../img/memberSlider8.png);
  background-size: contain;
  background-repeat: no-repeat;
  background-position: right;
}
.members .slide:nth-of-type(8) .slideBox .right {
  flex: 1.7;
  width: 100%;
  height: 100%;
  text-align: left;
  padding: 25px 0px 0px 70px;
}
.members .slide:nth-of-type(8) .slideBox .right h3 {
  font: 14px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 15px;
}
.members .slide:nth-of-type(8) .slideBox .right h2 {
  font: bold 36px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 20px;
}
.members .slide:nth-of-type(8) .slideBox .right p {
  font: 16px/1.8 "Noto Sans KR";
  color: #333;
  padding-right: 20vw;
}
.members .slide:nth-of-type(8) .slideBox .right p span {
  font: 25px/1 "Noto Sans KR";
  color: #333;
}
.members .slide:nth-of-type(9) {
  width: 100%;
  height: 100%;
  background: #66c2f6;
  padding: 40px;
}
.members .slide:nth-of-type(9) .slideBox {
  width: 100%;
  height: 100%;
  display: flex;
}
.members .slide:nth-of-type(9) .slideBox .left {
  flex: 1;
  width: 100%;
  height: 100%;
  background-image: url(../img/memberSlider9.png);
  background-size: contain;
  background-repeat: no-repeat;
  background-position: right;
}
.members .slide:nth-of-type(9) .slideBox .right {
  flex: 1.7;
  width: 100%;
  height: 100%;
  text-align: left;
  padding: 25px 0px 0px 70px;
}
.members .slide:nth-of-type(9) .slideBox .right h3 {
  font: 14px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 15px;
}
.members .slide:nth-of-type(9) .slideBox .right h2 {
  font: bold 36px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 20px;
}
.members .slide:nth-of-type(9) .slideBox .right p {
  font: 16px/1.8 "Noto Sans KR";
  color: #333;
  padding-right: 20vw;
}
.members .slide:nth-of-type(9) .slideBox .right p span {
  font: 25px/1 "Noto Sans KR";
  color: #333;
}
.members .next,
.members .prev {
  padding: 30px 20px;
  display: block;
  position: absolute;
  top: 50%;
  transform: translateY(-50%);
  background: #171717;
  color: white;
  font: bold 26px/1 "Noto Sans KR";
  border: none;
}
.members .next {
  right: 0;
}
.members .membersBox {
  width: 100%;
  height: 754px;
  padding: 0px 15vw 0px;
  display: flex;
  flex-wrap: wrap;
  position: relative;
  margin-bottom: 50px;
}
.members .membersBox:nth-of-type(1) {
  width: 100%;
  height: 519px;
  display: flex;
}
.members .membersBox:nth-of-type(1) .membersName {
  flex: 1;
  height: 50px;
  padding: 180px 0px;
}
.members .membersBox:nth-of-type(1) .membersName h1 {
  font: bold 50px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 20px;
}
.members .membersBox:nth-of-type(1) .membersName h3 {
  font: 20px/1 "Noto Sans KR";
  color: rgba(16, 16, 16, 0.6);
}
.members .membersBox:nth-of-type(1) .membersDesc {
  font: 18px/1 "Noto Sans KR";
  color: #333;
  text-align: justify;
  word-break: break-all;
  padding: 60px 0px 60px;
  width: 35%;
  height: 240px;
  background: rgb(255, 255, 255);
  position: absolute;
  z-index: 500;
  bottom: 0;
  left: 0;
  margin-left: 15vw;
}
.members .membersBox:nth-of-type(1) .membersDesc p {
  width: 90%;
  font: 16px/1.8 "Noto Sans KR";
  color: #333;
}
.members .membersBox:nth-of-type(1) .membersImg {
  flex: 2;
  width: 50%;
  height: 100%;
  background: rgb(32, 32, 32);
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
  position: relative;
  z-index: -5;
  overflow: hidden;
}
.members .membersBox:nth-of-type(1) .membersImg .colorBg {
  width: 500px;
  height: 500px;
  position: relative;
  background: #fedc01;
  z-index: 999;
  transform: translate(50%, 40%);
  opacity: 0.6;
  mix-blend-mode: darken;
}
.members .membersBox:nth-of-type(2) {
  width: 100%;
  height: 519px;
  display: flex;
  flex-direction: row-reverse;
}
.members .membersBox:nth-of-type(2) .membersName {
  flex: 1;
  height: 50px;
  padding: 180px 0px;
  text-align: right;
}
.members .membersBox:nth-of-type(2) .membersName h1 {
  font: bold 50px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 20px;
}
.members .membersBox:nth-of-type(2) .membersName h3 {
  font: 20px/1 "Noto Sans KR";
  color: rgba(16, 16, 16, 0.6);
}
.members .membersBox:nth-of-type(2) .membersDesc {
  font: 18px/1 "Noto Sans KR";
  color: #333;
  text-align: justify;
  word-break: break-all;
  padding: 60px 0px 60px;
  width: 35%;
  height: 240px;
  background: rgb(255, 255, 255);
  position: absolute;
  z-index: 500;
  bottom: 0;
  right: 0;
  margin-right: 15vw;
}
.members .membersBox:nth-of-type(2) .membersDesc p {
  width: 90%;
  font: 16px/1.8 "Noto Sans KR";
  color: #333;
  text-align: right;
  margin-left: 10%;
}
.members .membersBox:nth-of-type(2) .membersImg {
  flex: 2;
  width: 50%;
  height: 100%;
  background: rgb(32, 32, 32);
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
  position: relative;
  z-index: -5;
  overflow: hidden;
}
.members .membersBox:nth-of-type(2) .membersImg .colorBg {
  width: 650px;
  height: 300px;
  position: relative;
  background: #fedc01;
  z-index: 999;
  transform: translate(15%, 40%);
  opacity: 0.6;
  mix-blend-mode: darken;
}
.members .membersBox:nth-of-type(3) {
  width: 100%;
  height: 519px;
  display: flex;
}
.members .membersBox:nth-of-type(3) .membersName {
  flex: 1;
  height: 50px;
  padding: 180px 0px;
}
.members .membersBox:nth-of-type(3) .membersName h1 {
  font: bold 50px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 20px;
}
.members .membersBox:nth-of-type(3) .membersName h3 {
  font: 20px/1 "Noto Sans KR";
  color: rgba(16, 16, 16, 0.6);
}
.members .membersBox:nth-of-type(3) .membersDesc {
  font: 18px/1 "Noto Sans KR";
  color: #333;
  text-align: justify;
  word-break: break-all;
  padding: 60px 0px 60px;
  width: 35%;
  height: 240px;
  background: rgb(255, 255, 255);
  position: absolute;
  z-index: 500;
  bottom: 0;
  left: 0;
  margin-left: 15vw;
}
.members .membersBox:nth-of-type(3) .membersDesc p {
  width: 90%;
  font: 16px/1.8 "Noto Sans KR";
  color: #333;
}
.members .membersBox:nth-of-type(3) .membersImg {
  flex: 2;
  width: 50%;
  height: 100%;
  background: rgb(32, 32, 32);
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
  position: relative;
  z-index: -5;
  overflow: hidden;
}
.members .membersBox:nth-of-type(3) .membersImg .colorBg {
  width: 700px;
  height: 500px;
  position: relative;
  background: #fedc01;
  z-index: 999;
  transform: translate(30%, 40%);
  opacity: 0.6;
  mix-blend-mode: darken;
}
.members .membersBox:nth-of-type(4) {
  width: 100%;
  height: 519px;
  display: flex;
  flex-direction: row-reverse;
  margin-bottom: 150px;
}
.members .membersBox:nth-of-type(4) .membersName {
  flex: 1;
  height: 50px;
  padding: 180px 0px;
  text-align: right;
}
.members .membersBox:nth-of-type(4) .membersName h1 {
  font: bold 50px/1 "Noto Sans KR";
  color: #333;
  margin-bottom: 20px;
}
.members .membersBox:nth-of-type(4) .membersName h3 {
  font: 20px/1 "Noto Sans KR";
  color: rgba(16, 16, 16, 0.6);
}
.members .membersBox:nth-of-type(4) .membersDesc {
  font: 18px/1 "Noto Sans KR";
  color: #333;
  text-align: justify;
  word-break: break-all;
  padding: 60px 0px 60px;
  width: 35%;
  height: 240px;
  background: rgb(255, 255, 255);
  position: absolute;
  z-index: 500;
  bottom: 0;
  right: 0;
  margin-right: 15vw;
}
.members .membersBox:nth-of-type(4) .membersDesc p {
  width: 90%;
  font: 16px/1.8 "Noto Sans KR";
  color: #333;
  text-align: right;
  margin-left: 10%;
}
.members .membersBox:nth-of-type(4) .membersImg {
  flex: 2;
  width: 50%;
  height: 100%;
  background: rgb(32, 32, 32);
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
  position: relative;
  z-index: -5;
  overflow: hidden;
}
.members .membersBox:nth-of-type(4) .membersImg .colorBg {
  width: 600px;
  height: 500px;
  position: relative;
  background: #fedc01;
  z-index: 999;
  transform: translate(20%, 20%);
  opacity: 0.6;
  mix-blend-mode: darken;
}

.signUp {
  width: 100vw;
  height: 100vh;
}
.signUp .titContainer {
  width: 100%;
  height: 300px;
  padding: 150px 20vw 150px;
  display: flex;
  flex-direction: column;
  margin-bottom: 150px;
}
.signUp .titContainer h1 {
  flex: 1;
  text-align: center;
  font: bold 70px/1 "Noto Sans KR";
  color: #333;
  margin-top: 20px;
  margin-bottom: 96px;
}
.signUp .titContainer h2 {
  flex: 1;
  text-align: left;
  font: bold 18px/1.3 "Noto Sans KR";
  color: #333;
  position: absolute;
  transform: translate(-50%, -50%);
  top: 50%;
  left: 50%;
  white-space: nowrap;
}
.signUp .timeLine {
  flex: 1;
  width: 100%;
  height: 300px;
  display: flex;
  flex-direction: row;
  flex-wrap: nowrap;
  justify-content: center;
  padding-bottom: 60px;
  border-bottom: 1px solid #cfcfcf;
  gap: 104px;
}
.signUp .timeLine .timeLineNum {
  width: 117px;
  height: 117px;
  border-radius: 50%;
  float: left;
  border: 1px solid #cfcfcf;
  position: relative;
}
.signUp .timeLine .timeLineNum:nth-of-type(2) {
  background: #fec202;
  border: none;
}
.signUp .timeLine .timeLineNum::after {
  content: "\f061";
  position: relative;
  align-items: center;
  top: 30%;
  left: -70%;
  transform: translate(50%, 50%);
  font: 30px/1 "Noto Sans KR";
  color: #cfcfcf;
  display: inline-block;
  font-family: "Font Awesome 5 Free";
  font-weight: 900;
}
.signUp .timeLine .timeLineNum:nth-of-type(1):after {
  content: ">";
  position: relative;
  align-items: center;
  top: 50%;
  left: -50%;
  transform: translate(50%, 50%);
  font: bold 25px/1 "Noto Sans KR";
  color: #969696;
  display: none;
}
.signUp .info1 {
  width: 100%;
  height: 517px;
  margin-bottom: 200px;
  padding: 150px 20vw 150px;
}
.signUp .info1 h2 {
  font: bold 26px/1 "Noto Sans KR";
  color: #333;
  padding-bottom: 2vw;
}
.signUp .info1 form table {
  width: 100%;
  height: 517px;
  padding: 30px;
  background: #f4f5f6;
}
.signUp .info1 form table th,
.signUp .info1 form table td {
  padding: 16px 18px;
}
.signUp .info1 form table th {
  font: bold 18px/1 "Noto Sans KR";
  color: #171717;
  transform: translate(0%, -14%);
  text-align: left;
  padding: 0px 2vw 0px;
}
.signUp .info1 form table th:nth-of-type(1)::after {
  content: "*";
  font: bold 18px/1 "Noto Sans KR";
  color: red;
}
.signUp .info1 form table td {
  width: 80%;
}
.signUp .info1 form table p {
  font: 16px/1 "Noto Sans KR";
  color: #333;
}
.signUp .info1 form table p::before {
  content: "\f00c";
  display: inline-block;
  font-family: "Font Awesome 5 Free";
  font-weight: 900;
  margin-right: 18px;
}
.signUp .info1 form table .checkIdBtn,
.signUp .info1 form table .checkNickBtn {
  width: 108px;
  height: 41px;
  background: #1b2539;
  border-radius: 5px;
  color: #eee;
  border: none;
  transform: translate(0, -5%);
  font: 15px/1 "Noto Sans KR";
}
.signUp .info1 form table input[type=text] {
  padding: 10px;
  width: 30%;
  height: 40px;
  border-radius: 5px;
  border: 1px solid #cfcfcf;
  background: #f4f5f6;
  margin-bottom: 15px;
  font: 16px/1 "Noto Sans KR";
}
.signUp .info1 form table input[type=password] {
  padding: 10px;
  width: 30%;
  height: 40px;
  border-radius: 5px;
  border: 1px solid #cfcfcf;
  background: #fff;
  color: red;
  margin-bottom: 15px;
}
.signUp .info1 form table input[placeholder] {
  padding: 10px;
  width: 30%;
  height: 40px;
  border-radius: 5px;
  border: 1px solid #cfcfcf;
  background: #fff;
  font: 16px/1 "Noto Sans KR";
  color: #333;
}
.signUp .info1 form table input[type=email] {
  padding: 10px;
  width: 20%;
  height: 40px;
  border-radius: 5px;
  border: 1px solid #cfcfcf;
  background: #fff;
  font: 16px/1 "Noto Sans KR";
  color: #333;
}
.signUp .info1 form table select {
  padding: 2px 10px;
  width: 15%;
  height: 40px;
  border-radius: 5px;
  border: 1px solid #cfcfcf;
  background: #f4f5f6;
  font: 16px/1 "Noto Sans KR";
  color: #333;
  transform: translate(0, -1%);
}
.signUp .info2 {
  width: 100%;
  height: 517px;
  margin-bottom: 200px;
  padding: 150px 20vw 150px;
}
.signUp .info2 h2 {
  font: bold 26px/1 "Noto Sans KR";
  color: #333;
  padding-bottom: 2vw;
}
.signUp .info2 form table {
  width: 100%;
  height: 517px;
  padding: 30px;
  background: #f4f5f6;
}
.signUp .info2 form table th,
.signUp .info2 form table td {
  padding: 16px 18px;
}
.signUp .info2 form table th {
  font: bold 18px/1 "Noto Sans KR";
  color: #171717;
  text-align: left;
  padding: 0px 2vw 0px;
  transform: translate(0%, -3%);
}
.signUp .info2 form table td {
  width: 80%;
}
.signUp .info2 form table span {
  font: 16px/1 "Noto Sans KR";
  color: #969696;
}
.signUp .info2 form table button {
  width: 108px;
  height: 41px;
  background: #1b2539;
  border: 1px solid #171717;
  border-radius: 5px;
  color: #eee;
  border: none;
  transform: translate(0, -5%);
  font: 15px/1 "Noto Sans KR";
}
.signUp .info2 form table input[type=text] {
  padding: 10px;
  width: 40%;
  height: 40px;
  border-radius: 5px;
  border: 1px solid #cfcfcf;
  background: #fff;
  margin-bottom: 10px;
  font: 16px/1 "Noto Sans KR";
}
.signUp .info2 form table textarea[placeholder] {
  padding: 10px;
  width: 92%;
  border-radius: 5px;
  border: 1px solid #cfcfcf;
  background: #fff;
  font: 16px/1 "Noto Sans KR";
  color: #333;
}
.signUp .info2 form table input[placeholder] {
  padding: 10px;
  width: 92%;
  height: 40px;
  border-radius: 5px;
  border: 1px solid #cfcfcf;
  background: #fff;
  font: 16px/1 "Noto Sans KR";
  color: #333;
}
.signUp .info2 form table input[type=checkbox] {
  margin-left: 20px;
  margin-bottom: 20px;
}
.signUp .info2 form table input[type=checkbox]:nth-of-type(1) {
  margin-left: 0;
}
.signUp .info2 form table select {
  padding: 10px;
  width: 15%;
  height: 40px;
  border-radius: 5px;
  border: 1px solid #cfcfcf;
  background: #f4f5f6;
  font: 16px/1 "Work Sans";
  color: #333;
  transform: translate(0, 8%);
}
.signUp .info2 form table input[class=address]:nth-of-type(2) {
  width: 92%;
}
.signUp .info2 form table input[class=address]:nth-of-type(3) {
  width: 92%;
}
.signUp .info2 form table .addressTit::after {
  content: "*";
  font: bold 18px/1 "Noto Sans KR";
  color: red;
}
.signUp .info3 {
  width: 100%;
  height: 185px;
  margin-top: 480px;
  margin-bottom: 250px;
  padding: 50px 20vw 0px;
}
.signUp .info3 h2 {
  font: bold 26px/1 "Noto Sans KR";
  color: #333;
  padding-bottom: 2vw;
}
.signUp .info3 form table {
  width: 100%;
  height: 185px;
  padding: 30px;
  background: #f4f5f6;
}
.signUp .info3 form table th,
.signUp .info3 form table td {
  padding: 16px 18px;
}
.signUp .info3 form table th {
  font: bold 18px/1 "Noto Sans KR";
  color: #171717;
  text-align: left;
  padding: 0px 2vw 0px;
}
.signUp .info3 form table td {
  width: 80%;
}
.signUp .info3 form table input[type=radio] {
  margin-left: 20px;
}
.signUp .info3 form table input[type=radio]:nth-of-type(1) {
  margin-left: -20px;
}
.signUp .btnSet {
  display: flex;
  justify-content: center;
  align-items: center;
  width: 60%;
  height: 200px;
  padding: 0px 20vw 0px;
  margin: 0px auto;
  border-top: 1px solid #cfcfcf;
}
.signUp .btnSet input {
  width: 108px;
  height: 41px;
  background: #1b2539;
  border-radius: 5px;
  color: #eee;
  border: none;
  transform: translate(0, -5%);
  font: 15px/1 "Noto Sans KR";
  margin-right: 30px;
  cursor: pointer;
}
.signUp .btnSet input:nth-of-type(1) {
  background: #fff;
  border: 1px solid #1b2539;
  color: #333;
}

@media screen and (max-width: 1023px) {
  .signUp .titContainer {
    height: 300px;
    padding: 150px 10vw 150px;
    margin-bottom: 150px;
  }
  .signUp .titContainer h1 {
    font: bold 38.4px/1 "Noto Sans KR";
    margin-top: 20px;
    margin-bottom: 96px;
  }
  .signUp .titContainer h2 {
    font: bold 16px/1.3 "Noto Sans KR";
  }
  .signUp .timeLine {
    height: 300px;
    padding-bottom: 60px;
  }
  .signUp .timeLine .timeLineNum {
    width: 104px;
    height: 104px;
  }
  .signUp .timeLine .timeLineNum::after {
    transform: translate(50%, 50%);
    font: 18px/1 "Noto Sans KR";
    font-family: "Font Awesome 5 Free";
    font-weight: 900;
  }
  .signUp .info1 {
    width: 100%;
    height: 517px;
    margin-bottom: 200px;
    padding: 150px 10vw 150px;
  }
  .signUp .info1 h2 {
    font: bold 22.4px/1 "Noto Sans KR";
    color: #333;
    padding-bottom: 5vw;
  }
  .signUp .info1 form table {
    width: 100%;
    height: 517px;
    padding: 30px;
    background: #f4f5f6;
  }
  .signUp .info1 form table th,
  .signUp .info1 form table td {
    padding: 16px 18px;
  }
  .signUp .info1 form table th {
    font: bold 14.4px/1 "Noto Sans KR";
    color: #171717;
    transform: translate(0%, -14%);
    text-align: left;
    padding: 0px 1vw 0px;
  }
  .signUp .info1 form table th:nth-of-type(1)::after {
    font: bold 16px/1 "Noto Sans KR";
  }
  .signUp .info1 form table td {
    width: 80%;
  }
  .signUp .info1 form table p {
    font: 12.8px/1 "Noto Sans KR";
  }
  .signUp .info1 form table p::before {
    margin-right: 5px;
  }
  .signUp .info1 form table .checkIdBtn,
  .signUp .info1 form table .checkNickBtn {
    width: 96px;
    height: 37px;
    font: 12.8px/1 "Noto Sans KR";
  }
  .signUp .info1 form table input[type=text] {
    padding: 5px;
    width: 50%;
    height: 37px;
    margin-bottom: 15px;
    font: 14.4px/1 "Noto Sans KR";
  }
  .signUp .info1 form table input[type=password] {
    padding: 5px;
    width: 30%;
    height: 37px;
    border-radius: 5px;
    margin-bottom: 15px;
  }
  .signUp .info1 form table input[placeholder] {
    padding: 5px;
    width: 50%;
    height: 37px;
    font: 14.4px/1 "Noto Sans KR";
  }
  .signUp .info1 form table input[type=email] {
    padding: 5px;
    width: 28%;
    height: 37px;
    font: 14.4px/1 "Noto Sans KR";
  }
  .signUp .info1 form table select {
    padding: 2px 5px;
    width: 25%;
    height: 37px;
    border-radius: 5px;
    font: 14.4px/1 "Noto Sans KR";
    transform: translate(0, -1%);
  }
  .signUp .info2 {
    padding: 150px 10vw 150px;
  }
  .signUp .info2 h2 {
    font: bold 22.4px/1 "Noto Sans KR";
    padding-bottom: 5vw;
  }
  .signUp .info2 form table {
    width: 100%;
    height: 517px;
    padding: 30px;
  }
  .signUp .info2 form table th,
  .signUp .info2 form table td {
    padding: 16px 18px;
  }
  .signUp .info2 form table th {
    font: bold 14.4px/1 "Noto Sans KR";
    padding: 0px 1vw 0px;
  }
  .signUp .info2 form table span {
    font: 14.4px/1 "Noto Sans KR";
  }
  .signUp .info2 form table button {
    height: 37px;
    font: 12.8px/1 "Noto Sans KR";
  }
  .signUp .info2 form table input[type=text] {
    padding: 5px;
    width: 50%;
    height: 37px;
    margin-bottom: 10px;
    font: 14.4px/1 "Noto Sans KR";
  }
  .signUp .info2 form table textarea[placeholder] {
    padding: 5px;
    font: 14.4px/1 "Noto Sans KR";
  }
  .signUp .info2 form table input[placeholder] {
    padding: 5px;
    width: 50%;
    height: 37px;
    font: 14.4px/1 "Noto Sans KR";
  }
  .signUp .info2 form table select {
    padding: 5px;
    width: 18%;
    height: 37px;
    font: 14.4px/1 "Work Sans";
  }
  .signUp .info2 form table input[class=address]:nth-of-type(2) {
    width: 92%;
  }
  .signUp .info2 form table input[class=address]:nth-of-type(3) {
    width: 92%;
  }
  .signUp .info2 form table .addressTit::after {
    font: bold 14.4px/1 "Noto Sans KR";
  }
  .signUp .info3 {
    margin-top: 530px;
    padding: 0px 10vw 0px;
  }
  .signUp .info3 h2 {
    font: bold 22.4px/1 "Noto Sans KR";
    padding-bottom: 5vw;
  }
  .signUp .info3 form table th,
  .signUp .info3 form table th {
    font: bold 14.4px/1 "Noto Sans KR";
    padding: 0px 1vw 0px;
  }
  .signUp .btnSet {
    width: 80%;
    padding: 0px 10vw 0px;
  }
  .signUp .btnSet input {
    font: 12.8px/1 "Noto Sans KR";
  }
}
@media screen and (max-width: 639px) {
  .signUp .titContainer {
    height: 300px;
    padding: 150px 5vw 150px;
    margin-bottom: 150px;
  }
  .signUp .titContainer h1 {
    font: bold 33.6px/1 "Noto Sans KR";
    margin-top: 20px;
    margin-bottom: 96px;
  }
  .signUp .titContainer h2 {
    font: bold 14px/1.3 "Noto Sans KR";
  }
  .signUp .timeLine {
    height: 300px;
    padding-bottom: 60px;
  }
  .signUp .timeLine .timeLineNum {
    width: 91px;
    height: 91px;
  }
  .signUp .timeLine .timeLineNum:nth-child(2):after {
    display: none;
  }
  .signUp .timeLine .timeLineNum:nth-of-type(1) {
    display: none;
  }
  .signUp .timeLine .timeLineNum::after {
    font: bold 16px/1 "Noto Sans KR";
    transform: translate(50%, 50%);
    font-family: "Font Awesome 5 Free";
    font-weight: 900;
  }
  .signUp .info1 {
    width: 100%;
    height: 517px;
    padding: 96px 5vw 96px;
    margin-bottom: 96px;
  }
  .signUp .info1 h2 {
    font: bold 19.6px/1 "Noto Sans KR";
    padding-bottom: 10vw;
  }
  .signUp .info1 form table {
    width: 100%;
    height: 517px;
    padding: 30px 10px 20px;
    background: #f4f5f6;
  }
  .signUp .info1 form table th,
  .signUp .info1 form table td {
    padding: 16px 0px;
    flex-wrap: wrap;
    display: flex;
  }
  .signUp .info1 form table th {
    font: bold 14.4px/1 "Noto Sans KR";
    transform: translate(0%, -14%);
    padding: 0px 1vw 0px;
  }
  .signUp .info1 form table th:nth-of-type(1)::after {
    font: bold 12.6px/1 "Noto Sans KR";
  }
  .signUp .info1 form table td {
    width: 100%;
  }
  .signUp .info1 form table p {
    width: 100%;
    font: 11.2px/1 "Noto Sans KR";
  }
  .signUp .info1 form table p::before {
    margin-right: 5px;
  }
  .signUp .info1 form table .checkIdBtn,
  .signUp .info1 form table .checkNickBtn {
    width: 30%;
    height: 32.8px;
    margin-left: 5px;
    font: 11.2px/1 "Noto Sans KR";
  }
  .signUp .info1 form table input[type=text] {
    padding: 5px;
    width: 65%;
    height: 32.8px;
    margin-bottom: 10px;
    font: 12.6px/1 "Noto Sans KR";
  }
  .signUp .info1 form table input[type=password] {
    width: 100%;
    height: 32.8px;
    margin-bottom: 10px;
  }
  .signUp .info1 form table input[placeholder] {
    padding: 5px;
    width: 100%;
    height: 32.8px;
    font: 12.6px/1 "Noto Sans KR";
  }
  .signUp .info1 form table input[type=email] {
    padding: 5px;
    width: 29%;
    height: 32.8px;
    font: 14.4px/1 "Noto Sans KR";
  }
  .signUp .info1 form table select {
    padding: 2px 5px;
    width: 30%;
    height: 32.8px;
    border-radius: 5px;
    font: 14.4px/1 "Noto Sans KR";
    transform: translate(0, -1%);
    margin-left: 5px;
  }
  .signUp .info2 {
    margin-top: 150px;
    width: 100%;
    height: 517px;
    padding: 96px 5vw 96px;
  }
  .signUp .info2 h2 {
    font: bold 19.6px/1 "Noto Sans KR";
    padding-bottom: 10vw;
  }
  .signUp .info2 form table {
    width: 100%;
    height: 517px;
    padding: 30px 10px 20px;
  }
  .signUp .info2 form table th,
  .signUp .info2 form table td {
    padding: 16px 0px;
    display: flex;
    flex-wrap: wrap;
  }
  .signUp .info2 form table td {
    width: 100%;
    font: 12.6px/1 "Noto Sans KR";
  }
  .signUp .info2 form table th {
    font: bold 14.4px/1 "Noto Sans KR";
    padding: 0px 1vw 0px;
  }
  .signUp .info2 form table span {
    font: 12.6px/1 "Noto Sans KR";
  }
  .signUp .info2 form table button {
    height: 32.8px;
    font: 11.2px/1 "Noto Sans KR";
  }
  .signUp .info2 form table input[type=text] {
    padding: 5px;
    width: 100%;
    height: 32.8px;
    font: 12.6px/1 "Noto Sans KR";
  }
  .signUp .info2 form table textarea[placeholder] {
    padding: 5px;
    width: 100%;
    font: 12.6px/1 "Noto Sans KR";
  }
  .signUp .info2 form table input[type=checkbox] {
    margin-left: 10px;
    margin-bottom: 10px;
  }
  .signUp .info2 form table input[type=checkbox]:nth-of-type(1) {
    margin-left: 0;
  }
  .signUp .info2 form table input[placeholder] {
    padding: 5px;
    width: 100%;
    height: 32.8px;
    font: 12.6px/1 "Noto Sans KR";
  }
  .signUp .info2 form table select {
    padding: 5px;
    width: 30%;
    height: 32.8px;
    font: 12.6px/1 "Work Sans";
  }
  .signUp .info2 form table input[class=address]:nth-of-type(1) {
    width: 40%;
    margin-right: 5px;
  }
  .signUp .info2 form table input[class=address]:nth-of-type(2) {
    width: 100%;
  }
  .signUp .info2 form table input[class=address]:nth-of-type(3) {
    width: 100%;
  }
  .signUp .info2 form table .addressTit::after {
    font: bold 12.6px/1 "Noto Sans KR";
  }
  .signUp .info3 {
    margin-top: 150px;
    padding: 206px 5vw 150px;
  }
  .signUp .info3 h2 {
    font: bold 19.6px/1 "Noto Sans KR";
    padding-bottom: 10vw;
  }
  .signUp .info3 form table {
    width: 100%;
    height: 193px;
    padding: 30px 10px 20px;
  }
  .signUp .info3 form table th,
  .signUp .info3 form table td {
    padding: 0px 1vw 0px;
    display: flex;
    flex-wrap: wrap;
  }
  .signUp .info3 form table th {
    margin-bottom: 20px;
    font: bold 14.4px/1 "Noto Sans KR";
  }
  .signUp .info3 form table td {
    font: 12.6px/1 "Noto Sans KR";
    margin-bottom: 20px;
    margin-left: 5vw;
  }
  .signUp .btnSet {
    width: 85%;
    padding: 0px 10vw 0px;
  }
  .signUp .btnSet input {
    font: 12.8px/1 "Noto Sans KR";
    margin-right: 10px;
  }
}
.video {
  width: 100vw;
  min-height: calc(100vh - 461px);
}
.video .subVisual {
  width: 100%;
  height: 480px;
  position: relative;
  overflow: hidden;
}
.video .subVisual video {
  object-fit: contain;
  object-position: 0vw -28vw;
}
.video .subVisual .background {
  width: 50%;
  height: 80px;
  background: #090909;
  position: absolute;
  bottom: 0;
  left: 0;
}
.video .titContainer {
  width: 100%;
  height: 300px;
  padding: 150px 15vw 246px;
  background: #090909;
}
.video .titContainer h1 {
  text-align: left;
  font: bold 70px/1 "Noto Sans KR";
  color: #eee;
  margin-top: 20px;
  margin-bottom: 96px;
}
.video .subtitle {
  width: 100%;
  height: 500px;
  background: #090909;
  padding: 0px 15vw 50px;
  display: flex;
  flex-wrap: wrap;
}
.video .subtitle .subLeft {
  width: 50%;
  height: 100%;
  position: relative;
  padding-right: 100px;
}
.video .subtitle .subLeft h3 {
  font: 26px/1 "Noto Sans KR";
  color: #eee;
  margin-bottom: 20px;
}
.video .subtitle .subLeft .title {
  font: bold 51px/1.3 "Noto Sans KR";
  background: radial-gradient(circle, #7f7fd5, #86a8e7, #91eae4);
  background-size: 200%;
  -webkit-background-clip: text;
  color: transparent;
  animation: animation 1.7s linear infinite;
  margin-bottom: 15px;
}
@keyframes animation {
  to {
    background-position: 200% center;
  }
}
.video .subtitle .subLeft p {
  font: 16px/1.6 "Noto Sans KR";
  color: #eee;
  text-align: justify;
  word-break: break-all;
  width: 95%;
  margin-top: -0.7vw;
}
.video .subtitle .subLeft img {
  transform: translate(-15%, 5%);
  width: 238px;
  height: 238px;
}
.video .subtitle .subRight {
  width: 50%;
  height: 200%;
  margin-top: -395px;
  position: relative;
}
.video .subtitle .subRight video {
  width: 100%;
  height: 100%;
  object-fit: cover;
}
.video .subtitle .subRight .pauseBtn {
  width: 30px;
  height: 30px;
  background: transparent;
  position: absolute;
  z-index: 9999;
  bottom: 30px;
  left: 30px;
  font: 26px/1 "Noto Sans KR";
  color: #eee;
  background-image: url(../img/pauseWhite.png);
  background-repeat: no-repeat;
  background-size: contain;
  border: none;
  cursor: pointer;
}
.video .subtitle .subRight .playBtn {
  width: 30px;
  height: 30px;
  background: transparent;
  position: absolute;
  z-index: 9999;
  bottom: 30px;
  left: 30px;
  font: 26px/1 "Noto Sans KR";
  color: #eee;
  background-image: url(../img/playWhite.png);
  background-repeat: no-repeat;
  background-size: contain;
  border: none;
  cursor: pointer;
  display: none;
}
.video .middleText {
  width: 100%;
  height: auto;
  background: #090909;
  display: flex;
  flex-direction: column;
  padding: 96px 14.9vw 96px;
  background: #090909;
  z-index: 2;
}
.video .middleText p {
  font: 36px/1.3 "Noto Sans KR";
  color: #eee;
  margin-bottom: 96px;
  text-align: justify;
  word-wrap: break-word;
  background: #090909;
  padding-top: 36px;
}
.video .middleText button {
  width: 259px;
  height: 56px;
  font: 15px/1 "Noto Sans KR";
  color: #171717;
  border-radius: 50px;
  margin: 0px auto;
  margin-bottom: 50px;
  cursor: pointer;
  background: radial-gradient(circle, #7f7fd5, #86a8e7, #91eae4);
  background-size: 200%;
  border: none;
  animation: animation 1.7s linear infinite;
}
@keyframes animation {
  to {
    background-position: 200% center;
  }
}
.video .imgBoxContainer {
  width: 100%;
  height: 900px;
  display: flex;
  flex-wrap: wrap;
  background: #090909;
  padding: 0px 15vw 150px;
}
.video .imgBoxContainer .imgBoxLeft {
  width: 50%;
  height: 100%;
  position: relative;
}
.video .imgBoxContainer .imgBoxLeft video {
  width: 100%;
  height: 100%;
  object-fit: cover;
  object-position: center;
}
.video .imgBoxContainer .imgBoxLeft .pauseBtn2 {
  width: 30px;
  height: 30px;
  background: transparent;
  position: absolute;
  z-index: 9999;
  bottom: 30px;
  left: 30px;
  font: 26px/1 "Noto Sans KR";
  color: #eee;
  background-image: url(../img/pauseWhite.png);
  background-repeat: no-repeat;
  background-size: contain;
  border: none;
  cursor: pointer;
}
.video .imgBoxContainer .imgBoxLeft .playBtn2 {
  width: 30px;
  height: 30px;
  background: transparent;
  position: absolute;
  z-index: 9999;
  bottom: 30px;
  left: 30px;
  font: 26px/1 "Noto Sans KR";
  color: #eee;
  background-image: url(../img/playWhite.png);
  background-repeat: no-repeat;
  background-size: contain;
  border: none;
  cursor: pointer;
  display: none;
}
.video .imgBoxContainer .imgBoxRight {
  width: 50%;
  height: 100%;
  display: flex;
  flex-direction: column;
}
.video .imgBoxContainer .imgBoxRight .imgBoxTop {
  width: 100%;
  height: 50%;
  display: flex;
}
.video .imgBoxContainer .imgBoxRight .imgBoxTop .imgBox1 {
  flex: 1;
  width: 50%;
  height: 100%;
  overflow: hidden;
  position: relative;
  cursor: pointer;
}
.video .imgBoxContainer .imgBoxRight .imgBoxTop .imgBox1 img {
  width: 100%;
  height: 100%;
  object-fit: cover;
  object-position: center;
}
.video .imgBoxContainer .imgBoxRight .imgBoxTop .imgBox1 button {
  width: 80px;
  height: 80px;
  background: #dcdcdc;
  border-radius: 50%;
  border: none;
  position: absolute;
  top: 20px;
  right: 20px;
  font: bold 16px/1 "Noto Sans KR";
  color: #333;
  cursor: pointer;
}
.video .imgBoxContainer .imgBoxRight .imgBoxTop .imgBox2 {
  flex: 1;
  width: 50%;
  height: 100%;
  background: rgb(89, 135, 150);
  overflow: hidden;
}
.video .imgBoxContainer .imgBoxRight .imgBoxTop .imgBox2 img {
  width: 100%;
  height: 100%;
  object-fit: cover;
  object-position: center;
}
.video .imgBoxContainer .imgBoxRight .imgBoxDown {
  width: 100%;
  height: 50%;
  display: flex;
  overflow: hidden;
}
.video .imgBoxContainer .imgBoxRight .imgBoxDown img {
  width: 100%;
  height: 100%;
  object-fit: cover;
  object-position: center;
}
.video .imbedVideoContainer {
  width: 100%;
  height: 453.39px;
  padding: 0px 15vw 0px;
  display: flex;
  background: #090909;
}
.video .imbedVideoContainer .imbedText {
  flex: 0.6;
  width: 50%;
  height: 100%;
  background: #1b1b1b;
  padding: 42px;
}
.video .imbedVideoContainer .imbedText h2 {
  margin-top: 5vw;
  font: bold 26px/1 "Noto Sans KR";
  color: #eee;
}
.video .imbedVideoContainer .imbedText p {
  margin-top: 3vw;
  font: 16px/1.5 "Noto Sans KR";
  color: #eee;
}
.video .imbedVideoContainer .imbedVideo {
  flex: 1;
  width: 50%;
  height: 100%;
  overflow: hidden;
  position: relative;
  height: 0;
  padding-bottom: 56.25%;
}
.video .imbedVideoContainer .imbedVideo iframe {
  width: 100%;
}
.video .btnContainer {
  width: 100%;
  height: auto;
  background: #090909;
  display: flex;
  padding: 96px 15vw 0px;
}
.video .btnContainer button {
  width: 259px;
  height: 56px;
  background-color: #f9f9f9;
  font: 15px/1 "Noto Sans KR";
  color: #171717;
  border-radius: 50px;
  margin: 0px auto;
  cursor: pointer;
  border: none;
  background: radial-gradient(circle, #7f7fd5, #86a8e7, #91eae4);
  background-size: 200%;
  animation: animation 1.7s linear infinite;
}
@keyframes animation {
  to {
    background-position: 200% center;
  }
}
.video .videoListContainer {
  width: 100%;
  height: auto;
  background: #090909;
  padding: 150px 15vw 100px;
  flex-direction: row;
}
.video .videoListContainer .container {
  width: 100%;
  height: 100%;
  display: flex;
  flex-wrap: wrap;
  background: #090909;
  justify-content: center;
  gap: 40px;
}
.video .videoListContainer .container .viedoBox1 {
  width: 300px;
  height: 300px;
  background: #090909;
  position: relative;
  margin-bottom: 50px;
}
.video .videoListContainer .container .viedoBox1 .textBox {
  width: 50%;
  height: 100%;
  background: #090909;
  position: absolute;
  top: 0;
  right: 0;
  border: 1px solid;
  padding: 16px;
  background-position: center;
  background-size: cover;
  background-repeat: no-repeat;
  overflow: hidden;
}
.video .videoListContainer .container .viedoBox1 .textBox .listTitle {
  font: bold 20px/1.2 "Noto Sans KR";
  text-align: start;
  color: #eee;
}
.video .videoListContainer .container .viedoBox1 .textBox p {
  margin-top: 3vw;
  font: 16px/1.5 "Noto Sans KR";
  color: #e9e9e9;
  text-align: justify;
  word-break: break-all;
}
.video .videoListContainer .container .videoCircle {
  width: 100%;
  height: 100%;
  background-color: #f9f9f9;
  border-radius: 50%;
  cursor: pointer;
  background-size: cover;
  background-position: center;
  background-repeat: no-repeat;
}
.video .videoListContainer .container .videoCircle:hover {
  animation: rotate 1.7s linear infinite;
  color: transparent;
}
@keyframes rotate {
  to {
    transform: rotate(360deg);
  }
}

@media screen and (max-width: 1023px) {
  .video .subVisual {
    height: 380px;
  }
  .video .subVisual video {
    object-fit: contain;
    object-position: -55vw -48vw;
  }
  .video .subVisual .background {
    background: #090909;
  }
  .video .titContainer {
    padding: 150px 10vw 246px;
    background: #090909;
  }
  .video .titContainer h1 {
    font: bold 70px/1 "Noto Sans KR";
    margin-top: 20px;
    margin-bottom: 96px;
  }
  .video .subtitle {
    height: auto;
    padding: 150px 10vw 50px;
  }
  .video .subtitle .subLeft {
    order: 2;
    width: 100%;
    padding-top: 450px;
  }
  .video .subtitle .subRight {
    width: 100%;
    height: 500px;
    margin-top: -16vw;
  }
  .video .subtitle .subRight video {
    width: 100%;
    height: 900px;
  }
  .video .middleText {
    padding: 0px 10vw 26px;
  }
  .video .middleText p {
    margin-bottom: 66px;
  }
  .video .imgBoxContainer {
    padding: 35px 10vw 90px;
  }
  .video .imbedVideoContainer {
    height: 676px;
    padding: 0px 10vw 0px;
    flex-direction: column;
  }
  .video .imbedVideoContainer .imbedText {
    flex: 0.2;
    width: 100%;
    height: 197px;
    padding: 42px;
  }
  .video .imbedVideoContainer .imbedText h2 {
    margin-top: 0;
  }
  .video .imbedVideoContainer .imbedText p {
    margin-top: 2vw;
  }
  .video .imbedVideoContainer .imbedVideo {
    flex: 1;
    width: 100%;
    height: 479px;
  }
  .video .btnContainer {
    width: 100%;
    height: auto;
    background: #090909;
    display: flex;
    padding: 86px 15vw 0px;
  }
  .video .videoListContainer {
    padding: 96px 10vw 150px;
  }
  .video .videoListContainer .container {
    gap: 40px;
  }
  .video .videoListContainer .container .viedoBox1 {
    margin-bottom: 10px;
  }
  .video .videoListContainer .container .viedoBox1 .textBox {
    padding: 30px;
  }
  .video .videoListContainer .container .viedoBox1 .textBox h3 {
    font: bold 26px/1.5 "Noto Sans KR";
    color: #eee;
  }
  .video .videoListContainer .container .viedoBox1 .textBox p {
    margin-top: 3vw;
    font: 16px/1.5 "Noto Sans KR";
    color: #e9e9e9;
  }
  .video .videoListContainer .container .videoCircle {
    width: 100%;
    height: 100%;
    background-color: #f9f9f9;
    border-radius: 50%;
  }
}
@media screen and (max-width: 639px) {
  .video .subVisual {
    height: 300px;
  }
  .video .subVisual video {
    object-position: -205vw -110vw;
  }
  .video .subVisual .background {
    background: #090909;
  }
  .video .titContainer {
    padding: 96px 5vw 0px;
    background: #090909;
  }
  .video .titContainer h1 {
    font: bold 36px/1 "Noto Sans KR";
    margin-top: 20px;
    margin-bottom: 0px;
  }
  .video .subtitle {
    height: auto;
    padding: 0px 5vw 50px;
  }
  .video .subtitle .subLeft {
    padding-top: 56px;
  }
  .video .subtitle .subLeft h3 {
    font: 25px/1 "Noto Sans KR";
    white-space: nowrap;
  }
  .video .subtitle .subLeft .title {
    font: bold 36px/1.3 "Noto Sans KR";
  }
  .video .subtitle .subLeft p {
    font: 16px/1.6 "Noto Sans KR";
    width: 120%;
  }
  .video .subtitle .subLeft img {
    width: 130px;
    height: 130px;
  }
  .video .subtitle .subRight {
    width: 100%;
    height: 500px;
    margin-top: -10vw;
  }
  .video .subtitle .subRight video {
    width: 100%;
    height: 100%;
  }
  .video .middleText {
    padding: 0px 5vw 26px;
  }
  .video .middleText p {
    font: 16px/1.6 "Noto Sans KR";
    margin-bottom: 66px;
  }
  .video .middleText button {
    width: 215px;
    height: 40px;
    font: 12px/1 "Noto Sans KR";
    border: none;
  }
  .video .imgBoxContainer {
    width: 100%;
    height: auto;
    padding: 0px 5vw 50px;
  }
  .video .imgBoxContainer .imgBoxLeft {
    width: 100%;
    height: 500px;
  }
  .video .imgBoxContainer .imgBoxLeft video {
    width: 100%;
    height: 100%;
    object-fit: cover;
    object-position: center;
  }
  .video .imgBoxContainer .imgBoxRight {
    width: 100%;
    height: 100%;
  }
  .video .imgBoxContainer .imgBoxRight .imgBoxTop {
    width: 100;
    height: 100%;
    display: block;
  }
  .video .imgBoxContainer .imgBoxRight .imgBoxTop .imgBox1 {
    width: 100%;
    height: 368px;
  }
  .video .imgBoxContainer .imgBoxRight .imgBoxTop .imgBox1 img {
    width: 100%;
  }
  .video .imgBoxContainer .imgBoxRight .imgBoxTop .imgBox2 {
    width: 100%;
    height: 368px;
  }
  .video .imgBoxContainer .imgBoxRight .imgBoxDown {
    width: 100%;
    height: 368px;
  }
  .video .imbedVideoContainer {
    height: 460px;
    padding: 0px 5vw 0px;
  }
  .video .imbedVideoContainer .imbedText {
    width: 100%;
    height: 217px;
  }
  .video .imbedVideoContainer .imbedVideo {
    width: 100%;
    height: 100%;
    padding-bottom: 0;
  }
  .video .imbedVideoContainer .imbedVideo iframe {
    width: 100%;
    height: 100%;
  }
  .video .btnContainer {
    padding: 55px 5vw 0px;
  }
  .video .btnContainer button {
    width: 215px;
    height: 40px;
    font: 12px/1 "Noto Sans KR";
  }
  .video .videoListContainer {
    padding: 80px 5vw 150px;
  }
  .video .videoListContainer .container .viedoBox1 .textBox {
    padding: 30px;
  }
  .video .videoListContainer .container .viedoBox1 .textBox h3 {
    font: 25px/1.5 "Noto Sans KR";
  }
  .video .videoListContainer .container .videoCircle {
    width: 100%;
    height: 100%;
    background-color: #f9f9f9;
    border-radius: 50%;
  }
}
#subVisual {
  width: 100vw;
  height: 100vh;
  background-image: url(../img/visual1.png);
  background-position: center;
  background-repeat: no-repeat;
  background-size: cover;
}
#subVisual .visualWrap {
  width: 100%;
  height: 100%;
  display: grid;
  grid-template-columns: 1fr 1fr 1fr 1fr 1fr 1fr 2fr;
  grid-template-rows: 0.8fr 1.7fr 1.7fr 3fr;
  backdrop-filter: brightness(0.6);
}
#subVisual .visualWrap .bg {
  height: 100%;
  border: 1px solid rgba(59, 59, 59, 0.5);
  color: yellow;
}
#subVisual .visualWrap .bg:nth-of-type(2) {
  grid-column: span 3;
}
#subVisual .visualWrap .bg:nth-of-type(7) {
  grid-column: span 3;
}
#subVisual .visualWrap .bg:nth-of-type(8) {
  padding: 15px 1vw 0px;
  font: 18px/1 "Work Sans";
  color: #e9e9e9;
  border: 1px solid #eee;
  cursor: pointer;
}
#subVisual .visualWrap .bg:nth-of-type(8).on {
  box-shadow: 0 0 50px 15px rgba(254, 194, 2, 0.45);
  background: #fec202;
  color: #171717;
  border: none;
}
#subVisual .visualWrap .bg:nth-of-type(9) {
  padding: 170px 1vw 15px;
  font: 18px/1 "Work Sans";
  color: #e9e9e9;
  text-align: start;
}
#subVisual .visualWrap .bg:nth-of-type(11) {
  grid-row: span 2;
}
#subVisual .visualWrap .bg:nth-of-type(12) {
  grid-column: span 4;
  grid-row: span 4;
  padding: 60px 0vw 0px;
}
#subVisual .visualWrap .bg:nth-of-type(12) h1 {
  width: 80%;
  font: 30px/1 "Work Sans";
  color: #e9e9e9;
  text-align: justify;
  word-break: break-all;
}
#subVisual .visualWrap .bg:nth-of-type(12) p {
  font: 18px/1 "Work Sans";
  color: #969696;
  text-align: justify;
  word-break: break-all;
  margin-bottom: 20px;
}
#subVisual .visualWrap .bg:nth-of-type(13) {
  text-align: end;
  padding: 170px 1vw 15px;
  font: 18px/1 "Work Sans";
  color: #e9e9e9;
  border: 1px solid #eee;
  cursor: pointer;
}
#subVisual .visualWrap .bg:nth-of-type(13).on {
  box-shadow: 0 0 50px 15px rgba(254, 194, 2, 0.45);
  background: #fec202;
  border: none;
  color: #171717;
  cursor: pointer;
}
#subVisual .visualWrap .bg:nth-of-type(14) {
  grid-row: span 2;
}

@media screen and (max-width: 1023px) {
  #visual {
    height: 100vh;
  }
  #visual .visualWrap {
    grid-template-columns: 0.6fr 0fr 0fr 1fr 1fr 1fr 0.6fr;
  }
  #visual .visualWrap .bg:nth-of-type(8) {
    padding: 20px 2vw 0px;
  }
  #visual .visualWrap .bg:nth-of-type(9) {
    padding: 170px 2vw 15px;
  }
  #visual .visualWrap .bg:nth-of-type(12) h1 {
    width: 90%;
    font: 28px/1 "Work Sans";
  }
  #visual .visualWrap .bg:nth-of-type(13) {
    padding: 170px 2vw 15px;
  }
}
@media screen and (max-width: 639px) {
  #visual {
    height: 80vh;
  }
  #visual .visualWrap {
    grid-template-columns: 0.1fr 0fr 0fr 0fr 1fr 1fr 0.1fr;
    grid-template-rows: 7fr 1.5fr 1.5fr 3fr;
  }
  #visual .visualWrap .bg:nth-of-type(8) {
    padding: 10px 3vw 0px;
  }
  #visual .visualWrap .bg:nth-of-type(9) {
    padding: 170px 3vw 10px;
  }
  #visual .visualWrap .bg:nth-of-type(12) {
    grid-column: span 4;
    grid-row: span 4;
    padding: 60px 0vw 0px;
  }
  #visual .visualWrap .bg:nth-of-type(12) h1 {
    display: none;
  }
  #visual .visualWrap .bg:nth-of-type(12) p {
    display: none;
  }
  #visual .visualWrap .bg:nth-of-type(13) {
    padding: 170px 3vw 10px;
  }
}
.gallery {
  width: 100%;
  overflow: hidden;
  position: relative;
}
.gallery .subVisual {
  width: 100%;
  height: 480px;
  position: relative;
  overflow: hidden;
}
.gallery .subVisual .background {
  width: 50%;
  height: 80px;
  background: white;
  position: absolute;
  bottom: 0;
  left: 0;
}
.gallery .titContainer {
  width: 100%;
  height: 300px;
  padding: 150px 15vw 246px;
}
.gallery .titContainer h1 {
  text-align: left;
  font: bold 70px/1 "Noto Sans KR";
  color: #333;
  margin-top: 20px;
  margin-bottom: 96px;
}
.gallery .searchBox {
  width: 100%;
  padding: 50px 10px 20px;
  font-size: 0;
}
.gallery .searchBox input {
  width: 260px;
  height: 30px;
  background: #fff;
  border: 1px solid #ddd;
  padding-left: 10px;
}
.gallery .searchBox .btnSearch {
  width: 80px;
  height: 29px;
  background: #333;
  color: #fff;
  font: bold 12px/29px "arial";
  text-align: center;
  border: none;
  cursor: pointer;
  margin-left: 5px;
  transform: translateY(-1px);
}
.gallery .loading {
  position: fixed;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  opacity: 1;
  transition: opacity 1s;
  z-index: 3;
}
.gallery .loading.off {
  opacity: 0;
  z-index: -1;
}
.gallery .wrap {
  opacity: 0;
  transform: translateY(100px);
  transition: 1s;
}
.gallery .wrap.on {
  opacity: 1;
  transform: translateY(0px);
}
.gallery .wrap::after {
  content: "";
  display: block;
  clear: both;
}
.gallery .wrap li {
  width: 20%;
  float: left;
  padding: 10px;
}
.gallery .wrap li > div {
  width: 100%;
  background: #fff;
  padding: 10px;
  box-shadow: 5px 5px 20px rgba(0, 0, 0, 0.05);
}
.gallery .wrap li > div .thumb {
  width: 100%;
}
.gallery .wrap li > div p {
  font: 18px/1.2 "Architects daughter";
  color: #777;
  margin-top: 10px;
  margin-bottom: 20px;
}
.gallery .wrap li > div .profile {
  width: 100%;
}
.gallery .wrap li > div .profile img {
  width: 36px;
}
.gallery .wrap li > div .profile span {
  display: inline-block;
  font: 12px/1 "arial";
  color: orange;
  margin-left: 5px;
  transform: translateY(-10px);
}

/*# sourceMappingURL=style.cs.map */
