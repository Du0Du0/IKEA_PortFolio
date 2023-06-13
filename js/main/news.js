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
		let ww = window.innerWidth;
		let swiper;

		responsiveSwiper();

		function initSwiper(effect) {
			if (typeof swiper == 'object') swiper.destroy();

			return (swiper = new Swiper('.first', {
				speed: 2000,
				disableOnInteraction: false,
				spaceBetween: 20,
				initialSlide: 1,
				autoHeight: false,
				allowTouchMove: true, // false시에 스와이핑이 되지 않으며 버튼으로만 슬라이드 조작이 가능
				direction: 'horizontal',
				loop: true,
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
				effect: effect,
				slidesPerView: 1,
				centeredSlides: true,
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
			}));
		}

		function responsiveSwiper() {
			if (ww >= 1920) {
				// 슬라이드 효과
				initSwiper('slide');
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
