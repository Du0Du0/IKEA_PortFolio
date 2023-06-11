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
   
<img class="smartBg " src = 'img/${data.picOn}'>
<button class="controlBtn "><i class="fa-solid fa-volume-high"></i>${data.control}</button>
    </div>
		<span class="animation">${data.animation}</span>
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

		controlBtns.forEach((btn, idx) => {
			btn.addEventListener('click', (e) => {
				e.preventDefault();
				btn.classList.toggle('on');

				if (btn.classList.contains('on')) {
					smartBgs[idx].src = `img/${smartData[idx].picOff}`;
					controlBtns[
						idx
					].innerHTML = `<i class="fa-solid fa-volume-high"></i>${smartData[idx].control1}`;
				} else {
					smartBgs[idx].src = `img/${smartData[idx].picOn}`;
					controlBtns[
						idx
					].innerHTML = `<i class="fa-solid fa-volume-high"></i>${smartData[idx].control}`;
				}
			});
		});

		// Swiper 인스턴스 생성
		const mainSwiper = new Swiper('.second', {
			speed: 2000,
			disableOnInteraction: false,
			spaceBetween: 10,
			initialSlide: 0,
			autoHeight: false,
			allowTouchMove: true, // false시에 스와이핑이 되지 않으며 버튼으로만 슬라이드 조작이 가능
			direction: 'horizontal',
			loop: false,
			oopedSlides: 1,
			breakpoints: {
				// 브라우저 320px 크기일 경우
				1920: { slidesPerView: 3, spaceBetween: 252 },
				// 브라우저 640px 크기일 경우
				640: { slidesPerView: 3, spaceBetween: 100 },

				580: { slidesPerView: 2, spaceBetween: 22 },
				// 브라우저 480px 크기일 경우
				480: { slidesPerView: 1, spaceBetween: 52 },
			},
			loopAdditionalSlides: 2,
			loopedSlides: 1,
			autoplay: {
				delay: 80000,
				stopOnLastSlide: false,
			},

			effect: 'slide',
			slidesPerView: 3,
			centeredSlides: false,
			slidesOffsetBefore: 0,
			grabCursor: true,
		});
	});
