body {
  margin: 0;
  padding: 0;
}

#topBannerAndNavBar {
  background-color: #434CCC;
  width: 100%;
  height: 120vh;
  color: white;
  font-family: DM Sans;
  padding: 0% 7%;
  box-sizing: border-box;
}
#topBannerAndNavBar nav {
  width: 100%;
  height: 15vh;
  display: flex;
}
#topBannerAndNavBar nav #logoContainer {
  width: 10%;
  height: 100%;
  display: flex;
  align-items: center;
}
#topBannerAndNavBar nav #logoContainer #mainLogo {
  width: 75%;
  height: 80%;
  border-radius: 50%;
}
#topBannerAndNavBar nav #navLinksContainer {
  width: 90%;
  height: 100%;
  display: flex;
  justify-content: flex-end;
  align-items: center;
  gap: 4%;
}
#topBannerAndNavBar nav #navLinksContainer a {
  font-size: 16px;
  font-weight: 700;
  text-decoration: none;
  cursor: pointer;
  color: white;
  font-family: DM Sans;
}
#topBannerAndNavBar nav #navLinksContainer button {
  background-color: #434CCC;
  padding: 13px 56px;
  border: 1px solid white;
  color: white;
  border-radius: 5px;
  cursor: pointer;
}
#topBannerAndNavBar nav #menuIcon {
  width: 20%;
  height: 20%;
  display: none;
}
#topBannerAndNavBar nav #hideLinksContainer {
  background-color: rgb(223, 223, 48);
  top: 15vh;
  right: 0;
  position: absolute;
  display: flex;
  flex-direction: column;
  justify-content: space-evenly;
  align-items: center;
  display: none;
}
#topBannerAndNavBar nav #hideLinksContainer a {
  font-size: 25px;
}
#topBannerAndNavBar #surbhiTopBlueBanner {
  width: 100%;
  height: 105vh;
  display: flex;
  box-sizing: border-box;
}
#topBannerAndNavBar #surbhiTopBlueBanner #topBannerContent {
  width: 45%;
  height: 100%;
  padding-top: 5%;
}
#topBannerAndNavBar #surbhiTopBlueBanner #topBannerContent #paraBeforeHeading {
  font-weight: 400;
  letter-spacing: 4.8px;
  font-size: 16px;
}
#topBannerAndNavBar #surbhiTopBlueBanner #topBannerContent h1 {
  font-family: DM Serif Display;
  font-size: 72px;
  font-weight: 400;
  margin: 0;
}
#topBannerAndNavBar #surbhiTopBlueBanner #topBannerContent div {
  width: 70%;
  height: fit-content;
}
#topBannerAndNavBar #surbhiTopBlueBanner #topBannerContent div p {
  font-size: 16px;
  font-weight: 700;
}
#topBannerAndNavBar #surbhiTopBlueBanner #topBannerContent div button {
  padding: 13px 55px;
  background: var(--Primary_2, #F1B505);
  color: white;
  border-radius: 5px;
  cursor: pointer;
  border: none;
  font-size: 16px;
  margin-top: 20px;
}
#topBannerAndNavBar #surbhiTopBlueBanner #topBannerImg {
  width: 55%;
  height: 100%;
}
#topBannerAndNavBar #surbhiTopBlueBanner #topBannerImg img {
  width: 100%;
  height: 95%;
}

@media screen and (min-width: 100px) and (max-width: 650px) {
  #topBannerAndNavBar {
    padding: 0% 5%;
    width: 100%;
    height: 105vh;
  }
  #topBannerAndNavBar nav {
    align-items: center;
    justify-content: space-between;
    box-sizing: border-box;
  }
  #topBannerAndNavBar nav #logoContainer {
    width: 50%;
  }
  #topBannerAndNavBar nav #logoContainer #mainLogo {
    width: 45%;
    height: 70%;
  }
  #topBannerAndNavBar nav #navLinksContainer {
    display: none;
  }
  #topBannerAndNavBar nav #menuIcon {
    width: 20%;
    height: 20%;
    transition: transform 0.2s;
    display: block;
  }
  #topBannerAndNavBar nav #menuIcon:hover {
    transform: scale(1.5);
  }
  #topBannerAndNavBar nav #menuIcon:hover ~ #hideLinksContainer {
    display: block;
    display: flex;
    flex-direction: column;
    justify-content: space-evenly;
    align-items: center;
  }
  #topBannerAndNavBar nav #hideLinksContainer {
    width: 60%;
    height: 40vh;
    border-radius: 10px;
  }
  #topBannerAndNavBar nav #hideLinksContainer a {
    font-size: 25px;
    text-decoration: none;
    color: black;
    font-weight: 600;
    cursor: pointer;
  }
  #topBannerAndNavBar #surbhiTopBlueBanner {
    width: 100%;
    height: 90vh;
    display: flex;
    flex-direction: column;
    box-sizing: border-box;
  }
  #topBannerAndNavBar #surbhiTopBlueBanner #topBannerContent {
    width: 100%;
    height: 50%;
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    box-sizing: border-box;
  }
  #topBannerAndNavBar #surbhiTopBlueBanner #topBannerContent #paraBeforeHeading {
    font-size: 14px;
    margin: 0;
  }
  #topBannerAndNavBar #surbhiTopBlueBanner #topBannerContent h1 {
    font-size: 56px;
    margin: 0;
  }
  #topBannerAndNavBar #surbhiTopBlueBanner #topBannerContent div {
    width: 90%;
    height: fit-content;
  }
  #topBannerAndNavBar #surbhiTopBlueBanner #topBannerContent div p {
    font-size: 16px;
    font-weight: 400;
    margin: 0;
  }
  #topBannerAndNavBar #surbhiTopBlueBanner #topBannerContent div button {
    padding: 5% 15%;
    font-size: 16px;
    font-weight: 700;
    margin-top: 10%;
  }
  #topBannerAndNavBar #surbhiTopBlueBanner #topBannerImg {
    width: 100%;
    height: 50%;
    padding-top: 4%;
  }
  #topBannerAndNavBar #surbhiTopBlueBanner #topBannerImg img {
    width: 100%;
    height: 95%;
  }
}
.bot {
  height: 656px;
  width: 100%;
  background-color: #434CCC;
  display: flex;
}
.bot #location {
  height: 464px;
  width: 570px;
  position: relative;
  left: 115px;
  top: 100px;
}
.bot .detail {
  position: relative;
  height: 464px;
  width: 569px;
  top: 100px;
  left: 200px;
}
.bot .largeimage {
  height: 464px;
  width: 570px;
}
.bot .smallimage {
  position: absolute;
  width: 72px;
  height: 72px;
  top: 44%;
  left: 46%;
}
.bot #anc {
  height: 24px;
  width: 107px;
  font-family: "DM Sans", sans-serif;
  color: #FFFFFF;
  size: 16px;
  line-height: 24px;
  letter-spacing: 30%;
}
.bot #SC {
  font-family: "DM Serif Display";
  width: 268px;
  line-height: 64px;
  font-size: 56px;
  color: white;
  margin-top: 21px;
  font-weight: 400;
}
.bot #mail {
  height: 76px;
  width: 470px;
  margin-top: 24px;
}
.bot #email {
  width: 100%;
  padding-bottom: 12px;
  padding-top: 15px;
  padding-left: 16px;
  border: 1px solid #ccc;
  border-radius: 4px;
}
.bot #msg {
  height: 124px;
  width: 470px;
}
.bot #message {
  width: 480px;
  height: 96px;
  border: 1px solid #ccc;
  border-radius: 4px;
}
.bot button {
  margin-top: 48px;
  height: 48px;
  width: 170px;
  color: white;
  background-color: #F1B505;
  font-family: "DM Sans";
  font-size: 16px;
  font-weight: 700;
  text-align: center;
  border-radius: 5px;
  border: #F1B505;
}

.main_303 {
  width: 100%;
  height: 768px;
  margin: auto;
  background-color: #FFDD78;
  display: flex;
  flex-direction: column;
}

.H2_303 {
  width: 469px;
  height: 64px;
  font-family: "DM Serif Display", serif;
  font-size: 56px;
  font-weight: 400;
  line-height: 64px;
  letter-spacing: 0px;
  text-align: center;
  margin-top: 60px;
  margin-bottom: 25px;
  margin-left: auto;
  margin-right: auto;
}

.Text_Big_303 {
  width: 570px;
  height: 83px;
  font-family: "DM Sans", sans-serif;
  font-size: 20px;
  font-weight: 400;
  line-height: 32px;
  letter-spacing: 0px;
  text-align: center;
  margin-top: 0px;
  margin-bottom: 36px;
  margin-left: auto;
  margin-right: auto;
}

.cards_303 {
  display: flex;
  width: 80%;
  height: auto;
  text-align: center;
  align-items: center;
  margin-top: 0%;
  margin-bottom: auto;
  margin-left: auto;
  margin-right: auto;
  gap: 3%;
}

.card_303 {
  width: 100%;
  height: auto;
  background-color: #FFFFFF;
  box-shadow: 0px 2px 4px 0px rgba(0, 0, 0, 0.2980392157);
  border-radius: 4px;
  margin: auto;
}

.image1_303 {
  width: 132px;
  height: 114px;
  margin-top: 64px;
  margin-bottom: 54px;
}

.H4_303 {
  width: 162px;
  height: 32px;
  font-family: "DM Serif Display", serif;
  font-size: 24px;
  font-weight: 400;
  line-height: 32px;
  letter-spacing: 0px;
  text-align: left;
  margin-top: 0%;
  margin-left: 30px;
  margin-bottom: 15px;
  color: black;
}

.Text_grey_303 {
  width: 306px;
  height: 48px;
  font-family: "DM Sans", sans-serif;
  font-size: 16px;
  font-weight: 400;
  line-height: 24px;
  letter-spacing: 0px;
  text-align: left;
  margin-left: 32px;
  color: rgba(0, 0, 0, 0.5019607843);
  margin-bottom: 25px;
}

.HR_303 {
  width: 338px;
  height: 1px;
  color: black;
  margin-left: 32px;
  opacity: 10.11%;
}

.material-symbols-outlined {
  width: 6px;
  height: 11px;
  position: relative;
  left: 85px;
  bottom: 22px;
  transform: rotate("-180deg");
}

.Text_303 {
  width: 88px;
  height: 24px;
  font-family: "DM Sans", sans-serif;
  font-size: 16px;
  font-weight: 700;
  line-height: 24px;
  letter-spacing: 0px;
  text-align: left;
  margin-left: 32px;
}

.image2_303 {
  width: 186px;
  height: 96px;
  margin: 73px 100px 63px 84px;
}

.H4_2_303 {
  width: 158px;
  height: 32px;
  font-family: "DM Serif Display", serif;
  font-size: 24px;
  font-weight: 400;
  line-height: 32px;
  letter-spacing: 0px;
  text-align: left;
  margin-top: 0%;
  margin-left: 30px;
  margin-bottom: 15px;
  color: black;
}

.image3_303 {
  width: 144px;
  height: 126px;
  margin: 58px 105px 48px 121px;
}

.H4_3_303 {
  width: 175px;
  height: 32px;
  font-family: "DM Serif Display", serif;
  font-size: 24px;
  font-weight: 400;
  line-height: 32px;
  letter-spacing: 0px;
  text-align: left;
  margin-top: 0%;
  margin-left: 30px;
  margin-bottom: 15px;
  color: black;
}

@media screen and (min-width: 100px) and (max-width: 1300px) {
  .main_303 {
    min-width: 425px;
    height: 1632px;
  }
  .H2_303 {
    width: 335px;
    height: auto;
    font-family: "DM Serif Display", serif;
    font-size: 40px;
    font-weight: 400;
    line-height: 48px;
    letter-spacing: 0px;
    text-align: center;
    margin-bottom: 30px;
  }
  .Text_Big_303 {
    width: 346px;
    height: auto;
    margin-bottom: 50px;
  }
  .cards_303 {
    gap: 16px;
    flex-direction: column;
  }
  .card_303 {
    width: 346px;
    height: auto;
    margin: auto;
  }
  .Text_grey_303 {
    width: 282px;
    height: auto;
  }
}
.aliquip {
  width: 100%;
  height: 1328px;
  background-color: #f5f6fc;
  border: 1px solid white;
  direction: flex;
  flex-wrap: wrap;
  flex-direction: column;
}
.aliquip .sam .samhead1 {
  color: var(--Text_Black, #000);
  text-align: center;
  /* H5 */
  font-family: DM Sans;
  font-size: 16px;
  font-style: normal;
  font-weight: 400;
  line-height: 24px;
  /* 150% */
  letter-spacing: 4.8px;
  margin-top: 63px;
}
.aliquip .sam .samhead2 {
  color: var(--Text_Black, #000);
  text-align: center;
  /* H2 */
  font-family: DM Serif Display;
  font-size: 56px;
  font-style: normal;
  font-weight: 400;
  line-height: 64px;
  /* 114.286% */
  margin-top: 21px;
}
.aliquip .sam .samText_Big {
  color: var(--Text_Black, #000);
  text-align: center;
  /* Text_Big */
  font-family: DM Sans;
  font-size: 20px;
  font-style: normal;
  font-weight: 400;
  line-height: 32px;
  /* 160% */
  margin-top: 29px;
}
.aliquip .samcontent {
  display: grid;
  margin-top: 13px;
  margin-bottom: 117px;
  margin-left: 135px;
  margin-right: 135px;
  grid-template-columns: repeat(2, 1fr);
  grid-template-rows: repeat(2, 1fr);
}
.aliquip .samcontent #somu1 {
  padding-left: 80px;
}
.aliquip .samcontent #somu1 #samimg1 {
  height: 456px;
  width: 485px;
  margin-right: 20px;
}
.aliquip .samcontent #somu2 {
  padding-right: 80px;
}
.aliquip .samcontent #somu2 .samhead {
  color: var(--Text_Black, #000);
  /* H3 */
  font-family: DM Serif Display;
  font-size: 40px;
  font-style: normal;
  font-weight: 400;
  line-height: 48px;
  margin-top: 97px;
  /* 120% */
  width: 323px;
  height: 96px;
  top: 1930px;
  left: 735px;
}
.aliquip .samcontent #somu2 .samText_Grey {
  width: 470px;
  height: 75px;
  top: 2063px;
  left: 735px;
  color: var(--text-black-50, rgba(0, 0, 0, 0.5));
  /* Text_Gray */
  font-family: DM Sans;
  font-size: 16px;
  font-style: normal;
  font-weight: 400;
  line-height: 24px;
  /* 150% */
  margin-top: 27px;
}
.aliquip .samcontent #somu2 .samText {
  color: var(--Text_Black, #000);
  /* Text */
  font-family: DM Sans;
  font-size: 16px;
  font-style: normal;
  font-weight: 700;
  line-height: 24px;
  /* 150% */
  margin-top: 37px;
  height: 24px;
  top: 2175px;
  left: 735px;
  width: 96px;
}
.aliquip #somu3 {
  padding-left: 80px;
}
.aliquip #somu3 .samhead {
  color: var(--Text_Black, #000);
  /* H3 */
  font-family: DM Serif Display;
  font-size: 40px;
  font-style: normal;
  font-weight: 400;
  line-height: 48px;
  /* 120% */
  width: 392px;
  height: 96px;
  top: 2410px;
  left: 235px;
  margin-top: 121px;
}
.aliquip #somu3 .samText_Grey {
  height: 75px;
  top: 2543px;
  left: 235px;
  color: var(--text-black-50, rgba(0, 0, 0, 0.5));
  /* Text_Gray */
  font-family: DM Sans;
  font-size: 16px;
  font-style: normal;
  font-weight: 400;
  line-height: 24px;
  /* 150% */
  margin-top: 37px;
}
.aliquip #somu3 .samText {
  color: var(--Text_Black, #000);
  /* Text */
  font-family: DM Sans;
  font-size: 16px;
  font-style: normal;
  font-weight: 700;
  line-height: 24px;
  /* 150% */
  margin-top: 37px;
}
.aliquip #somu4 {
  padding-right: 80px;
}
.aliquip #somu4 #samimg2 {
  height: 456px;
  width: 485px;
  margin-top: 40px;
}

#scriptorem {
  width: 100%;
  height: 270vh;
  background-color: #f5f6fc;
  border: 1px solid white;
  direction: flex;
  flex-direction: column;
}
#scriptorem .revsmain2 .revshead, #scriptorem .revsmain .revshead {
  color: var(--Text_Black, #000);
  text-align: center;
  /* H5 */
  font-family: DM Sans;
  font-size: 16px;
  font-style: normal;
  font-weight: 400;
  line-height: 24px;
  /* 150% */
  letter-spacing: 4.8px;
  text-transform: uppercase;
  margin-top: 63px;
}
#scriptorem .revsmain2 .revshead2, #scriptorem .revsmain .revshead2 {
  color: var(--Text_Black, #000);
  text-align: center;
  /* H2 */
  font-family: DM Serif Display;
  font-size: 56px;
  font-style: normal;
  font-weight: 400;
  line-height: 64px;
  /* 114.286% */
  margin-top: 21px;
}
#scriptorem .revsmain2 .revsp, #scriptorem .revsmain .revsp {
  color: var(--Text_Black, #000);
  text-align: center;
  /* Text_Big */
  font-family: DM Sans;
  font-size: 20px;
  font-style: normal;
  font-weight: 400;
  line-height: 160%;
  margin-top: 20px;
}
#scriptorem .revsflexbox {
  display: flex;
  gap: 30px;
  height: 85vh;
  flex-wrap: wrap;
  justify-content: space-between;
  margin-top: 36px;
  margin-left: 135px;
  margin-right: 135px;
  box-sizing: border-box;
}
#scriptorem .revsflexbox > div {
  height: 79vh;
  border-radius: 5px;
  background: #FFF;
  box-shadow: 0px 2px 4px 0px rgba(0, 0, 0, 0.3);
  background-color: white;
}
#scriptorem .revsflexbox > div img {
  width: 285px;
  height: 285px;
  padding: 23px;
  border-radius: 50%;
}
#scriptorem .revsflexbox > div h4 {
  color: var(--Text_Black, #000);
  padding-left: 23px;
  /* H4 */
  font-family: DM Serif Display;
  font-size: 24px;
  font-style: normal;
  font-weight: 400;
  line-height: 32px;
  /* 133.333% */
  margin-top: 0px;
}
#scriptorem .revsflexbox > div hr {
  margin-left: 23px;
  color: #e5e5e5;
}
#scriptorem .revsflexbox > div > div {
  display: flex;
  justify-content: space-between;
  margin-left: 23px;
  margin-right: 15px;
  margin-top: 0;
}
#scriptorem .revsflexbox > div > div p {
  /* Text_Gray */
  font-family: DM Sans;
  font-size: 16px;
  font-style: normal;
  font-weight: 400;
  line-height: 24px;
}
#scriptorem .revsflexbox > div > div img {
  width: 65px;
  height: 28px;
  margin-top: -8px;
  margin-top: -8px;
  padding-right: 0px;
}
#scriptorem .revsgrid {
  display: grid;
  grid-template-columns: repeat(3, 1fr);
  grid-template-rows: repeat(3, 1fr);
  gap: 24px 22px;
  margin-left: 135px;
  margin-right: 135px;
  margin-top: 52px;
}
#scriptorem .revsgrid > div {
  width: 340px;
  height: 144px;
  border-radius: 5px;
  background: #FFF;
  box-shadow: 0px 2px 4px 0px rgba(0, 0, 0, 0.3);
  display: flex;
}
#scriptorem .revsgrid > div img {
  margin: 32px 22px 63px 23px;
  fill: linear-gradient(225deg, #FFC105 0%, #737CFF 100%);
  width: 43px;
  height: 49px;
}
#scriptorem .revsgrid > div .revsheadgrid {
  color: var(--Text_Black, #000);
  /* H4 */
  font-family: DM Serif Display;
  font-size: 24px;
  font-style: normal;
  font-weight: 400;
  line-height: 32px; /* 133.333% */
  margin-top: 22px;
}
#scriptorem .revsgrid > div .revspgrid {
  color: var(--text-black-50, rgba(0, 0, 0, 0.5));
  /* Text_Gray */
  font-family: DM Sans;
  font-size: 16px;
  font-style: normal;
  font-weight: 400;
  line-height: 24px; /* 150% */
  color: var(--text-black-50, rgba(0, 0, 0, 0.5));
  margin-right: 28px;
  /* Text_Gray */
  font-family: DM Sans;
  font-size: 16px;
  font-style: normal;
  font-weight: 400;
  line-height: 24px; /* 150% */
  margin-top: -24px;
}

#molestiae-section {
  width: 100%;
  height: 345vh;
  position: relative;
  font-family: DM Sans;
}
#molestiae-section #blueContainer {
  width: 100%;
  height: 120vh;
  background-color: #434CCC;
  display: flex;
  justify-content: center;
}
#molestiae-section #blueContainer div {
  color: white;
  width: 38%;
  height: 60vh;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  text-align: center;
}
#molestiae-section #blueContainer div #head-molestie {
  font-size: 16px;
  font-weight: 400;
  letter-spacing: 4.8px;
}
#molestiae-section #blueContainer div #heading-h2 {
  font-family: DM Serif Display;
  font-size: 56px;
  font-weight: 400;
  margin: 0;
}
#molestiae-section #blueContainer div #para {
  font-size: 20px;
  font-weight: 400;
}
#molestiae-section #whiteContainer {
  width: 100%;
  height: 225vh;
  padding-left: 7%;
  padding-right: 7%;
  box-sizing: border-box;
}
#molestiae-section #whiteContainer #overlapingImgContainer {
  height: 240vh;
  width: 86%;
  top: 60vh;
  position: absolute;
}
#molestiae-section #whiteContainer #overlapingImgContainer #gridContainers {
  height: 150vh;
  width: 100%;
  display: grid;
  grid-template-columns: repeat(2, 1fr);
  grid-row-gap: 2%;
  grid-column-gap: 2%;
}
#molestiae-section #whiteContainer #overlapingImgContainer #gridContainers p {
  color: var(--text-white-50, rgba(255, 255, 255, 0.5));
  font-size: 16px;
  font-weight: 400;
}
#molestiae-section #whiteContainer #overlapingImgContainer #gridContainers h4 {
  color: var(--Text_White, #FFF);
  font-family: DM Serif Display;
  font-size: 24px;
  font-weight: 400;
  margin-top: 0;
}
#molestiae-section #whiteContainer #overlapingImgContainer #gridContainers h2 {
  color: var(--Text_White, #FFF);
  font-family: DM Serif Display;
  font-size: 56px;
  font-weight: 400;
  margin-top: 0;
  margin-bottom: 6%;
}
#molestiae-section #whiteContainer #overlapingImgContainer #gridContainers #yellowBackGroundCont {
  border-radius: 5px;
  background: url("./bigger-yellow-back-img.png"), lightgray 0px 0px/100% 100% no-repeat;
  background-size: cover;
  grid-area: 1/1/2/3;
  box-sizing: border-box;
  display: flex;
  justify-content: flex-start;
  align-items: center;
  padding-left: 8%;
}
#molestiae-section #whiteContainer #overlapingImgContainer #gridContainers #yellowBackGroundCont div {
  height: 50%;
  width: 38%;
  box-sizing: border-box;
}
#molestiae-section #whiteContainer #overlapingImgContainer #gridContainers #yellowBackGroundCont div button {
  padding: 2% 6%;
  background-color: #F1B505;
  color: #FFF;
  font-size: 16px;
  font-weight: 700;
  border: 1px solid white;
}
#molestiae-section #whiteContainer #overlapingImgContainer #gridContainers #pinkBackGroundCont {
  border-radius: 5px;
  background: url("./pink-background-img.png"), lightgray 0px 0px/100% 100% no-repeat;
  padding-left: 12%;
  padding-top: 10%;
}
#molestiae-section #whiteContainer #overlapingImgContainer #gridContainers .innerContentCont {
  height: fit-content;
  width: 32%;
}
#molestiae-section #whiteContainer #overlapingImgContainer #gridContainers .innerContentCont button {
  padding: 5% 10%;
  color: white;
  font-size: 16px;
  font-weight: 900;
  cursor: pointer;
  border: 1px solid white;
  background-color: transparent;
}
#molestiae-section #whiteContainer #overlapingImgContainer #gridContainers #skyblueBackGroundCont {
  border-radius: 5px;
  background: url("./skyblue-background-img.png"), lightgray 0px 0px/100% 100% no-repeat;
  padding-left: 12%;
  padding-top: 10%;
}
#molestiae-section #whiteContainer #overlapingImgContainer #buttonContainer {
  height: 30vh;
  width: 100%;
  text-align: center;
  padding-top: 5%;
}
#molestiae-section #whiteContainer #overlapingImgContainer #buttonContainer button {
  color: #434CCC;
  text-align: center;
  font-family: DM Sans;
  font-size: 16px;
  font-weight: 700;
  padding: 13px 49px;
}
#molestiae-section #whiteContainer #overlapingImgContainer #sec-Img-Content-Container {
  width: 100%;
  height: 80vh;
  display: flex;
}
#molestiae-section #whiteContainer #overlapingImgContainer #sec-Img-Content-Container div {
  width: 50%;
  height: 100%;
}
#molestiae-section #whiteContainer #overlapingImgContainer #sec-Img-Content-Container #imgContainer img {
  width: 90%;
  height: 100%;
}
#molestiae-section #whiteContainer #overlapingImgContainer #sec-Img-Content-Container #contentContainer #headingContainer {
  height: 60%;
  width: 100%;
  box-sizing: border-box;
}
#molestiae-section #whiteContainer #overlapingImgContainer #sec-Img-Content-Container #contentContainer #headingContainer h2 {
  font-family: DM Serif Display;
  font-size: 56px;
  font-weight: 400;
  margin-top: 0;
  margin-bottom: 8%;
}
#molestiae-section #whiteContainer #overlapingImgContainer #sec-Img-Content-Container #contentContainer #headingContainer p {
  font-size: 20px;
  font-weight: 400;
}
#molestiae-section #whiteContainer #overlapingImgContainer #sec-Img-Content-Container #contentContainer #cardContainer {
  height: 40%;
  width: 100%;
  display: flex;
  box-sizing: border-box;
}
#molestiae-section #whiteContainer #overlapingImgContainer #sec-Img-Content-Container #contentContainer #cardContainer h4 {
  font-family: DM Serif Display;
  font-size: 24px;
  font-weight: 400;
  margin-bottom: 0;
}
#molestiae-section #whiteContainer #overlapingImgContainer #sec-Img-Content-Container #contentContainer #cardContainer p {
  color: var(--text-black-50, rgba(0, 0, 0, 0.5));
  font-size: 16px;
  font-weight: 400;
  margin-top: 7%;
}

@media screen and (min-width: 100px) and (max-width: 650px) {
  #molestiae-section {
    width: 100%;
    height: 500vh;
  }
  #molestiae-section #blueContainer {
    height: 100vh;
  }
  #molestiae-section #blueContainer div {
    width: 95%;
    height: 40vh;
  }
  #molestiae-section #blueContainer div #heading-h2 {
    font-size: 40px;
  }
  #molestiae-section #whiteContainer {
    width: 100%;
    height: 400vh;
    padding: 0% 5%;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer {
    height: 300vh;
    width: 95%;
    top: 40vh;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #gridContainers {
    height: 240vh;
    width: 100%;
    display: grid;
    grid-template-columns: repeat(1, 1fr);
    grid-template-rows: repeat(3, 1fr);
    grid-row-gap: 1%;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #gridContainers h4 {
    font-size: 28px;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #gridContainers h2 {
    font-size: 40px;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #gridContainers #yellowBackGroundCont {
    background: url("./yellow-background-img.png"), lightgray 0px 0px/100% 100%;
    background-size: cover;
    grid-area: 1/1/2/2;
    justify-content: center;
    align-items: flex-start;
    padding-left: 0%;
    padding-top: 8%;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #gridContainers #yellowBackGroundCont div {
    height: 70%;
    width: 80%;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #gridContainers #yellowBackGroundCont div button {
    padding: 3% 10%;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #gridContainers #pinkBackGroundCont {
    border-radius: 5px;
    background: url("./small-pink-background-img.png"), lightgray 0px 0px/100% 100% no-repeat;
    background-size: cover;
    padding-left: 12%;
    padding-top: 10%;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #gridContainers .innerContentCont {
    height: fit-content;
    width: 32%;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #gridContainers .innerContentCont button {
    padding: 5% 10%;
    color: white;
    font-size: 16px;
    font-weight: 900;
    cursor: pointer;
    border: 1px solid rgb(199, 195, 195);
    background-color: transparent;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #gridContainers #skyblueBackGroundCont {
    border-radius: 5px;
    background: url("./small-skyblue-background-img.png"), lightgray 0px 0px/100% 100% no-repeat;
    background-size: cover;
    padding-left: 12%;
    padding-top: 10%;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #buttonContainer {
    height: 30vh;
    width: 100%;
    text-align: center;
    padding-top: 5%;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #buttonContainer button {
    color: #434CCC;
    text-align: center;
    font-family: DM Sans;
    font-size: 16px;
    font-weight: 700;
    padding: 13px 49px;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #sec-Img-Content-Container {
    width: 100%;
    height: 80vh;
    display: flex;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #sec-Img-Content-Container div {
    width: 50%;
    height: 100%;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #sec-Img-Content-Container #imgContainer img {
    width: 90%;
    height: 100%;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #sec-Img-Content-Container #contentContainer #headingContainer {
    height: 60%;
    width: 100%;
    box-sizing: border-box;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #sec-Img-Content-Container #contentContainer #headingContainer h2 {
    font-family: DM Serif Display;
    font-size: 56px;
    font-weight: 400;
    margin-top: 0;
    margin-bottom: 8%;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #sec-Img-Content-Container #contentContainer #headingContainer p {
    font-size: 20px;
    font-weight: 400;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #sec-Img-Content-Container #contentContainer #cardContainer {
    height: 40%;
    width: 100%;
    display: flex;
    box-sizing: border-box;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #sec-Img-Content-Container #contentContainer #cardContainer h4 {
    font-family: DM Serif Display;
    font-size: 24px;
    font-weight: 400;
    margin-bottom: 0;
  }
  #molestiae-section #whiteContainer #overlapingImgContainer #sec-Img-Content-Container #contentContainer #cardContainer p {
    color: var(--text-black-50, rgba(0, 0, 0, 0.5));
    font-size: 16px;
    font-weight: 400;
    margin-top: 7%;
  }
}
.container_194 {
  background-color: #434CCC;
  display: flex;
  width: 100%;
  height: 80vh;
  border: 1px solid;
}
.container_194 .girl_194 {
  width: 40%;
  height: 100%;
}
.container_194 .para_194 {
  width: 60%;
  height: 100%;
}
.container_194 .para_194 .h4_194 {
  font-size: 26.5px;
  font-family: "DM serif";
  font-weight: 400;
  line-height: 32px;
  letter-spacing: 0;
  text-align: left;
  width: 670px;
  height: 107px;
  margin: auto;
  margin-top: 40px;
  margin-left: 92px;
  color: white;
}
.container_194 .para_194 .h5_194 {
  width: 160px;
  height: 24px;
  font-family: "DM Sans";
  font-size: 16px;
  font-weight: 400;
  line-height: 33px;
  letter-spacing: 0.3em;
  text-align: left;
  margin-left: 92px;
  margin-top: 110px;
  color: white;
}
.container_194 .para_194 .span_194 {
  color: white;
  width: 125px;
  height: 32px;
  margin-left: 92px;
  margin-top: 183px;
  line-height: 46px;
  font-family: sans-serif;
  font-size: 20px;
  font-weight: 400;
}
.container_194 .para_194 .tag_194 {
  color: white;
  display: block;
  opacity: 50%;
  margin-left: 92px;
  line-height: 24px;
  font-size: 16px;
  font-family: sans-serif;
  font-weight: 400;
}

#arrow_194 {
  width: 13px;
  height: 21px;
  margin: 206px auto 0 152px;
  position: relative;
}

#arrow_1942 {
  width: 13px;
  height: 21px;
  display: block;
  margin: 20px auto 0 152px;
  transform: rotate(-180deg);
  position: relative;
}

#Bitmap_194 {
  border-radius: 50%;
  overflow: hidden;
  margin-top: 106px;
}

.girl_194 {
  display: flex;
}

.arrow_194 {
  width: 50%;
  height: 100%;
}

.bitmap_194 {
  width: 50%;
  height: 100%;
}

#novumContainer {
  width: 100%;
  height: 185vh;
  padding: 0% 7%;
  box-sizing: border-box;
  box-shadow: rgba(0, 0, 0, 0.05) 0px 0px 0px 1px;
  font-family: DM Sans;
}
#novumContainer #firstInnerCont {
  width: 100%;
  height: 110vh;
}
#novumContainer #firstInnerCont #firstContsOuterAlignCont {
  width: 100%;
  height: 75%;
  display: grid;
  grid-template-columns: repeat(2, 1fr);
  grid-column-gap: 3%;
}
#novumContainer #firstInnerCont #firstContsOuterAlignCont #headingAndParaCont,
#novumContainer #firstInnerCont #firstContsOuterAlignCont #buttonCont {
  width: 100%;
  height: 30%;
  box-sizing: border-box;
}
#novumContainer #firstInnerCont #firstContsOuterAlignCont #headingAndParaCont {
  padding-top: 6%;
}
#novumContainer #firstInnerCont #firstContsOuterAlignCont #headingAndParaCont h5 {
  font-size: 16px;
  font-weight: 400;
  letter-spacing: 4.8px;
  margin-bottom: 0;
}
#novumContainer #firstInnerCont #firstContsOuterAlignCont #headingAndParaCont h2 {
  font-family: DM Serif Display;
  font-size: 50px;
  font-weight: 400;
  margin: 0;
}
#novumContainer #firstInnerCont #firstContsOuterAlignCont #buttonCont {
  display: flex;
  justify-content: flex-end;
  align-items: center;
}
#novumContainer #firstInnerCont #firstContsOuterAlignCont #buttonCont button {
  border-radius: 5px;
  border: 1px solid var(--Primary_1, #434CCC);
  padding: 2% 5%;
  color: #434CCC;
  font-size: 16px;
  font-weight: 700;
  cursor: pointer;
  margin-top: 4%;
}
#novumContainer #firstInnerCont #firstContsOuterAlignCont .cards {
  width: 100%;
  height: 70%;
  box-shadow: rgba(60, 64, 67, 0.3) 0px 1px 2px 0px, rgba(60, 64, 67, 0.15) 0px 1px 3px 1px;
  border: 1px solid white;
}
#novumContainer #firstInnerCont #firstContsOuterAlignCont .cards .cardImgCont {
  height: 60%;
  width: 90%;
  margin-left: 5%;
  margin-top: 5%;
}
#novumContainer #firstInnerCont #firstContsOuterAlignCont .cards .cardImgCont img {
  width: 100%;
  height: 90%;
}
#novumContainer #firstInnerCont #firstContsOuterAlignCont .cards .cardContentCont {
  height: 35%;
  width: 100%;
  padding-left: 5%;
  box-sizing: border-box;
}
#novumContainer #firstInnerCont #firstContsOuterAlignCont .cards .cardContentCont p {
  color: var(--text-black-50, rgba(0, 0, 0, 0.5));
  font-size: 16px;
  font-weight: 400;
  margin-bottom: 3%;
  margin-top: 0px;
}
#novumContainer #firstInnerCont #firstContsOuterAlignCont .cards .cardContentCont h4 {
  font-family: DM Serif Display;
  font-size: 24px;
  font-weight: 400;
  margin-top: 0;
  margin-bottom: 4%;
}
#novumContainer #firstInnerCont #firstContsOuterAlignCont .cards .cardContentCont .horizontal-partition-container {
  border-top: 1px solid rgb(180, 180, 180);
  height: 30%;
  display: flex;
  align-items: flex-end;
}
#novumContainer #firstInnerCont #firstContsOuterAlignCont .cards .cardContentCont .horizontal-partition-container a {
  color: var(--Text_Black, #000);
  font-size: 16px;
  font-weight: 700;
  text-decoration: none;
}
#novumContainer #secInnerCont {
  width: 100%;
  height: 75vh;
  display: flex;
  justify-content: center;
  align-items: center;
}
#novumContainer #secInnerCont #secContOuterAlignCont {
  width: 100%;
  height: 52%;
  display: grid;
  grid-template-columns: repeat(4, 1fr);
  grid-column-gap: 2%;
}
#novumContainer #secInnerCont #secContOuterAlignCont #contentCont h5 {
  font-size: 16px;
  font-weight: 400;
  letter-spacing: 4.8px;
}
#novumContainer #secInnerCont #secContOuterAlignCont #contentCont h4 {
  font-family: DM Serif Display;
  font-size: 22px;
  font-weight: 400;
}
#novumContainer #secInnerCont #secContOuterAlignCont #contentCont #cameraIcon {
  padding: 3% 2% 1% 2%;
  border: 1px solid rgb(79, 79, 160);
  border-radius: 5px;
}
#novumContainer #secInnerCont #secContOuterAlignCont #contentCont #graySpan {
  color: var(--text-black-50, rgba(0, 0, 0, 0.5));
  font-size: 16px;
  font-weight: 400;
}
#novumContainer #secInnerCont #secContOuterAlignCont div {
  box-shadow: rgba(0, 0, 0, 0.05) 0px 1px 2px 0px;
}
#novumContainer #secInnerCont #secContOuterAlignCont div .img-imgContent {
  width: fit-content;
  height: fit-content;
}

footer {
  background-color: rgb(245, 246, 252);
  height: 400px;
  width: 100%;
  font-family: "DM-sans";
}
footer .soc {
  display: flex;
  gap: 13px;
}
footer .container {
  padding-top: 79px;
  display: flex;
  height: 320px;
  width: 100%;
}
footer .lastline {
  background-color: rgb(245, 246, 252);
  height: 80px;
  width: 100%;
  display: flex;
  font-family: "DM Sans";
  font-size: 16px;
  font-style: normal;
  font-weight: 400;
  line-height: 24px;
  color: var(--text-black-50, rgba(0, 0, 0, 0.5));
}
footer .lastline #leftline {
  margin-top: 27px;
  margin-left: 135px;
  margin-bottom: 29px;
}
footer .lastline #rightline {
  margin-right: 135px;
  margin-top: 27px;
  margin-left: 787px;
}
footer .soc {
  margin-top: 18px;
}
footer .footer-col {
  flex-grow: 1;
}
footer .logos {
  flex-basis: 33.32%;
  margin-left: 135px;
  margin-top: 20px;
}
footer .logos .log {
  height: 32px;
  width: 62px;
}
footer .logos .des {
  height: 79px;
  width: 270px;
  color: var(--text-black-50, rgba(0, 0, 0, 0.5));
  font-size: 16px;
  font-style: normal;
  font-weight: 400;
  line-height: 24px;
}
footer .causae {
  flex-basis: 16.66%;
}
footer .aperiri {
  flex-basis: 16.66%;
}
footer .post {
  flex-basis: 33.32%;
}
footer a {
  text-decoration: none;
  color: var(--text-black-50, rgba(0, 0, 0, 0.5));
}
footer .ti {
  font-weight: 700;
}
footer .post {
  display: flex;
  flex-direction: column;
  gap: 39px;
}
footer .picpost {
  display: flex;
  gap: 30px;
}
footer .des {
  font-family: "DM Sans";
  font-size: 16px;
  font-style: normal;
  font-weight: 400;
  line-height: 24px;
  color: var(--text-black-50, rgba(0, 0, 0, 0.5));
}
footer .desc {
  height: 48px;
  width: 270px;
  font-size: 16px;
  font-weight: 400;
  color: var(--text-black-50, rgba(0, 0, 0, 0.5));
  font-family: "DM Sans";
}
footer .desc {
  width: 270px;
  font-size: 16px;
  font-weight: 400;
  color: var(--text-black-50, rgba(0, 0, 0, 0.5));
  font-family: "DM Sans";
}
footer .date {
  font-family: "DM Sans";
  font-size: 12px;
  font-weight: 700;
  line-height: 24px;
}

.date {
  font-family: "DM Sans";
  font-size: 12px;
  font-weight: 700;
  line-height: 24px;
}

.container5_303 {
  background-color: #434ccc;
  width: 100%;
  height: 656px;
  display: flex;
  margin: auto;
}
.container5_303 .side1_303 {
  width: 50%;
  height: 656px;
  background-color: #434ccc;
}
.container5_303 .side1_303 .H5_303 {
  width: 127px;
  height: 24px;
  color: white;
  font-family: "DM Sans", sans-serif;
  font-size: 16px;
  font-weight: 400;
  line-height: 24px;
  letter-spacing: 0.3em;
  text-align: left;
  margin: 127px 1178px 21px 135px;
}
.container5_303 .side1_303 .heading_303 {
  color: white;
  width: 331px;
  height: 128px;
  margin: 0px 974px 29px 135px;
  font-family: "DM Serif Display", serif;
  font-size: 56px;
  font-weight: 400;
  line-height: 64px;
  letter-spacing: 0px;
  text-align: left;
}
.container5_303 .side1_303 .textbig_303 {
  width: 470px;
  height: 103px;
  color: white;
  font-family: "DM Sans", sans-serif;
  font-size: 20px;
  font-weight: 400;
  line-height: 32px;
  letter-spacing: 0px;
  text-align: left;
  margin: 0px 835px 32px 135px;
}
.container5_303 .side1_303 .btn_303 {
  width: 170px;
  height: 48px;
  background-color: #f1b505;
  color: white;
  font-family: "DM Sans", sans-serif;
  margin: 0px 1135px 144px 135px;
  font-size: 16px;
  font-weight: 700;
  line-height: 24px;
  letter-spacing: 0px;
  text-align: center;
  border: none;
  border-radius: 4px;
}
.container5_303 .side2_303 {
  width: 50%;
  height: 656px;
}
.container5_303 .side2_303 .img_303 {
  width: 100%;
  height: 656px;
}

@media screen and (min-width: 100px) and (max-width: 650px) {
  .container5_303 {
    height: auto;
    display: grid;
    grid-template-columns: repeat(1, 1fr);
    grid-template-rows: repeat(2, 1fr);
  }
}

/*# sourceMappingURL=styles.cs.map */
