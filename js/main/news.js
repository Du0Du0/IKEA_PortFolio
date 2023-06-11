const newsSection = document.querySelector('#news');
const newSlideContainer = newsSection.querySelector('.first');
const newsWrap = newsSection.querySelector('.swiper-wrapper');
const nextBtn = newsSection.querySelector('.fa-chevron-right');
const preBtn = newsSection.querySelector('.fa-chevron-left');
const progress = document.querySelector('.swiper-progress-bar');

let tags = '';

fetch('DB/news.json')
	.then((res) => res.json())
	.then((data) => {
		const newsData = data.news;

		newsData.map((data) => {
			tags += `
    
    <div class="swiper-wrapper">
    <div class="swiper-slide on" style = "background-image : url('img/${data.pic}')">
    <h4>${data.title}</h4>
    <h2> ${data.subtitle}</h2>
    <p>${data.data}</p>
		
    </div>
    </div>
      `;
		});
		newSlideContainer.innerHTML = tags;
		// Swiper 인스턴스 생성
		const mainSwiper = new Swiper('.first', {
			speed: 2000,
			disableOnInteraction: false,
			spaceBetween: 252,
			initialSlide: 1,
			autoHeight: false,
			allowTouchMove: true, // false시에 스와이핑이 되지 않으며 버튼으로만 슬라이드 조작이 가능
			direction: 'horizontal',
			loop: true,
			breakpoints: {
				// 브라우저 320px 크기일 경우
				1920: { slidesPerView: 2, spaceBetween: 252 },
				// 브라우저 480px 크기일 경우
				480: { slidesPerView: 3, spaceBetween: 30 },
				// 브라우저 640px 크기일 경우
				640: { slidesPerView: 4, spaceBetween: 40 },
			},
			// loopAdditionalSlides: 2,
			// loopedSlides: 1,
			autoplay: {
				delay: 5000,
				stopOnLastSlide: false,
			},
			navigation: {
				nextEl: '.fa-chevron-right',
				prevEl: '.fa-chevron-left',
			},
			effect: 'slide',
			slidesPerView: 2,
			centeredSlides: false,
			slidesOffsetBefore: 0,
			grabCursor: true,
			pagination: {
				el: '.swiper-pagination',
				type: 'fraction',
			},
			on: {
				init: function () {
					const progressBars = document.querySelectorAll('.swiper-progress-bar');
					progressBars.forEach(function (progressBar) {
						progressBar.classList.remove('animate');
						progressBar.classList.remove('active');
					});
					progressBars[0].classList.add('animate');
					progressBars[0].classList.add('active');
				},
				slideChangeTransitionStart: function () {
					const progressBars = document.querySelectorAll('.swiper-progress-bar');
					progressBars.forEach(function (progressBar) {
						progressBar.classList.remove('animate');
						progressBar.classList.remove('active');
					});
					progressBars[0].classList.add('active');
				},
				slideChangeTransitionEnd: function () {
					const progressBars = document.querySelectorAll('.swiper-progress-bar');
					progressBars[0].classList.add('animate');
				},
			},
		});
	});

mainSwiper.controller.control = pagingSwiper;
