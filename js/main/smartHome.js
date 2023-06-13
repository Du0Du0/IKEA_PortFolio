const smartSection = document.querySelector('#smartHome');
const smartSlideContainer = smartSection.querySelector('.second');
const smartSlideWrap = smartSection.querySelector('  .swiper-wrapper');
const nextBtn = smartSection.querySelector('  .fa-chevron-right');
const preBtn = smartSection.querySelector(' .fa-chevron-left');

let tags = '';

fetch('DB/smartHome.json')
	.then((res) => res.json())
	.then((data) => {
		const smartData = data.smartHome;

		smartData.map((data) => {
			tags += `
    
    <div class="swiper-wrapper">
<div class="swiper-slide " >
    <h4>${data.topic}</h4>
    <h2> ${data.title}</h2>
   
<img class="smartBg on " src = 'img/${data.picOn}'>

    </div>
	
    </div>
		
      `;
		});
		smartSlideContainer.innerHTML = tags;

		const controlBtns = smartSection.querySelectorAll('.controlBtn');
		const smartBgs = smartSection.querySelectorAll('.smartBg');
		const swiperSlides = smartSection.querySelectorAll('.swiper-slide');
		const animation = smartSection.querySelectorAll('.animation');

		swiperSlides.forEach((swiperSlide, idx) => {
			swiperSlide.addEventListener('mouseenter', (e) => {
				e.preventDefault();
				smartBgs[idx].classList.add('on'); // smartBgs를 사용해야 함
				swiperSlides[idx].classList.add('on'); // smartBgs를 사용해야 함
				animation[idx].classList.add('movingText');
			});
		});

		swiperSlides.forEach((swiperSlide, idx) => {
			swiperSlide.addEventListener('mouseleave', (e) => {
				e.preventDefault();
				smartBgs[idx].classList.remove('on'); // smartBgs를 사용해야 함
				swiperSlides[idx].classList.remove('on'); // smartBgs를 사용해야 함
				animation[idx].classList.remove('movingText');
			});
		});

		// controlBtns.forEach((btn, idx) => {
		// 	btn.addEventListener('click', (e) => {
		// 		e.preventDefault();
		// 		btn.classList.toggle('on');

		// 		if (btn.classList.contains('on')) {
		// 			smartBgs[idx].src = `img/${smartData[idx].picOff}`;
		// 			controlBtns[
		// 				idx
		// 			].innerHTML = `<i class="fa-solid fa-volume-high"></i>${smartData[idx].control1}`;
		// 		} else {
		// 			smartBgs[idx].src = `img/${smartData[idx].picOn}`;
		// 			controlBtns[
		// 				idx
		// 			].innerHTML = `<i class="fa-solid fa-volume-high"></i>${smartData[idx].control}`;
		// 		}
		// 	});
		// });

		// Swiper 인스턴스 생성

		let ww = window.innerWidth;
		let swiper;

		responsiveSwiper();

		function initSwiper(effect) {
			if (typeof swiper == 'object') swiper.destroy();

			return (swiper = new Swiper('.second', {
				loop: false,
				spaceBetween: 252,
				slidesPerView: 3,
				disableOnInteraction: true,
				autoHeight: false,
				autoplay: {
					delay: 1000,
					disableOnInteraction: false,
				},
				effect: effect,
				centeredSlides: true,
				slideToClickedSlide: true,
				navigation: {
					nextEl: '.rightBtn',
					prevEl: '.leftBtn',
				},
			}));
		}

		function responsiveSwiper() {
			if (ww >= 1920) {
				// 슬라이드 효과
				initSwiper('slide');
			} else if (ww < 1024) {
				// 페이드 효과
				initSwiper('fade');
			} else if (ww < 1200) {
				// 페이드 효과
				initSwiper('fade');
			}
		}

		window.addEventListener('resize', function () {
			ww = window.innerWidth;
			responsiveSwiper();
		});
	});
//일정시간마다 배경이 바뀌는 스크립트
const imgArray = [
	'smartHomeBg1.png',
	'smartHomeBg2.png',
	'smartHomeBg3.png',
	'smartHomeBg4.png',
	'smartHomeBg5.png',
	'smartHomeBg6.png',
];

function showImage() {
	const imgNum = Math.floor(Math.random() * imgArray.length);
	const objImg = document.getElementById('smartHome');
	objImg.style.backgroundImage = `url(img/${imgArray[imgNum]})`;

	setTimeout(showImage, 4500);
}

showImage();
