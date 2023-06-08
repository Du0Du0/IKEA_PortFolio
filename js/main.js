//header
const headerSection = document.querySelector('header');
const rightBar = headerSection.querySelector('.rightBar');
const leftBar = headerSection.querySelector('.leftBar');
const menuBtn = headerSection.querySelector('.menu');
const BarBtn = headerSection.querySelector('.fa-bars-staggered');
const closeBtn = headerSection.querySelector('.fa-xmark');
const circleMouse = headerSection.querySelector('.circle');

//header
//header menu 클릭하면 오른쪽 바 내려옴
menuBtn.addEventListener('click', (e) => {
	const isRgtOn = rightBar.classList.contains('rgt');
	const isLeftOn = leftBar.classList.contains('lft');

	//header menu 클릭 시 사이드 바 나오는 기능
	isRgtOn
		? (rightBar.classList.remove('rgt'), leftBar.classList.remove('lft'))
		: (rightBar.classList.add('rgt'), leftBar.classList.add('lft'));

	//header sideBar 열리면 버튼이 x로 바뀌고 닫히면 원래 버튼으로 바뀌는 기능
	isRgtOn
		? ((BarBtn.style.display = 'block'), (closeBtn.style.display = 'none'))
		: ((BarBtn.style.display = 'none'), (closeBtn.style.display = 'block'));
});

//header mouseover 따라다니는 원 커서 기능
document.addEventListener('mousemove', (e) => {
	const mouseX = e.clientX;
	const mouseY = e.clientY;

	circleMouse.style.left = mouseX + 'px';
	circleMouse.style.top = mouseY + 'px';
});

//room
const roomSection = document.querySelector('#room');
const roomBtns = roomSection.querySelectorAll('.roomTab');
const roomBg = roomSection.querySelector('.roomBg');
const previewBg = roomSection.querySelector('.previewBg');
const roomTitle = roomSection.querySelector('.previewTit');
const roomSub = roomSection.querySelector('.previewSub');

const roomImgs = ['bg1.png', 'preview2.png', 'preview3.png', 'preview4.png'];

const preTit = [
	'Urban kitchen solutions',
	'Long-lasting style and quality',
	'An elegant living room',
	'A flexible room with space',
];

const preSub = [
	'Urban homes often mean small spaces and tricky architecture, but that doesn’t change the need for a storage-optimised (and stylish!) space for cooking. The flexible ENHET kitchen can tackle most nooks while letting you express your style to the fullest.',

	'A traditional look never goes out of style – so why not invest in the high-quality IDANÄS series of bedroom furniture that will be at your service for many years to come?',

	'Comfort and style go hand in hand in this colour coordinated living room where EKOLSUND recliner is the centre of attention. It can be adjusted into three positions: sit upright, lean back or lie back for a nap. How do you want to relax today?',

	'When you’ve got one room for your busy life, here’s a layout that gives you space to breathe. Whether you’re socialising, gaming or studying, it’s packed with useful ways to keep things running smoothly.',
];

//room 탭버튼 기능
roomBtns.forEach((roomBtn, idx) => {
	roomBtn.addEventListener('click', (e) => {
		e.preventDefault();

		//모든 버튼 비활성화
		for (const roomBtn of roomBtns) roomBtn.classList.remove('on');
		//클릭한 버튼 활성화
		roomBtns[idx].classList.add('on');

		// roomBg 사진 바뀜
		roomBg.style.backgroundImage = `url(img/${roomImgs[idx]})`;
		// previewBg 사진 바뀜
		previewBg.style.backgroundImage = `url(img/${roomImgs[idx]})`;
		roomTitle.innerHTML = `${preTit[idx]}`;
		roomSub.innerHTML = `${preSub[idx]}`;
	});
});

//vids

//youtube api
const vidsVideoWrap = document.querySelector('.vidsVideoWrap');
const key = 'AIzaSyCV2KoPa3MQ65lmbMraSlR-HwFY9dRqgF0';
const list = 'PLWgHnOZUp_4GvPcmipe9YROpmqMu9Tblz';
const num = 5;
const url = `https://www.googleapis.com/youtube/v3/playlistItems?part=snippet&playlistId=${list}&key=${key}&maxResults=${num}`;
let videoIsOn; // 변수를 미리 선언

fetch(url)
	.then((data) => data.json())
	.then((json) => {
		console.log(json.items);
		let tags = '';

		json.items.forEach((item, idx) => {
			let tit = item.snippet.title;
			let desc = item.snippet.description;

			tags += `
	  <div class="video ${idx === 1 ? 'on' : ''}" 
			data-video-id = "${item.snippet.resourceId.videoId}"
		style = "background-image : url(${json.items[idx].snippet.thumbnails.maxres.url}
			)">
    <div class="vidsNum">${item.snippet.position + 1}</div>
     <div class="vidsBarTit">${(tit.length > 20 ? tit.substr(0, 25) : tit) + '...'}</div>

    <span class="vidsOnSpan" style ="display: none">
		<h4>${(item.snippet.position + 1).toString().padStart(2, 0)}.</h4>
		<h2>${(tit.length > 50 ? tit.substr(0, 50) : tit) + '...'}</h2>
		<p>${(desc.length > 50 ? desc.substr(0, 300) : desc) + '...'}</p>
		<button class="discoverBtn">Discover Now</button>
</span>

</div>
			`;
		});
		vidsVideoWrap.innerHTML = tags;

		const vidsSection = document.querySelector('#vids');
		const videos = vidsSection.querySelectorAll('.video');
		const vidsNum = vidsSection.querySelectorAll('.vidsNum');
		const vidsBarTit = vidsSection.querySelectorAll('.vidsBarTit');
		const vidsSpan = vidsSection.querySelectorAll('.vidsOnSpan');

		// box클릭하면 해당 box열리는 기본 기능
		videos.forEach((video, idx) => {
			if (videos[idx].classList.contains('on')) {
				vidsNum[idx].style.display = 'none';
				vidsBarTit[idx].style.display = 'none';
				videos[idx].style.backgroundImage = `url(${json.items[idx].snippet.thumbnails.maxres.url})`;
				vidsSpan[idx].style.display = 'block';
			}

			video.addEventListener('click', (e) => {
				e.preventDefault();

				for (const video of videos) video.classList.remove('on');
				videos[idx].classList.add('on');

				videos[idx].classList.contains('on')
					? ((vidsNum[idx].style.display = 'none'),
					  (vidsBarTit[idx].style.display = 'none'),
					  ((videos[
							idx
					  ].style.backgroundImage = `url(${json.items[idx].snippet.thumbnails.maxres.url})`),
					  (vidsSpan[idx].style.display = 'block')))
					: ((vidsNum[idx].style.display = 'block'),
					  (vidsBarTit[idx].style.display = 'block'),
					  (vidsSpan[idx].style.display = 'none'));

				for (let i = 0; i < videos.length; i++) {
					if (!videos[i].classList.contains('on')) {
						vidsBarTit[i].style.display = 'block';
						vidsNum[i].style.display = 'block';
						vidsSpan[i].style.display = 'none';
					}
				}
			});
		});
	});

//vids pop 찹업창 띄우기
document.body.addEventListener('click', (e) => {
	console.log(e.target);
	if (e.target.className === 'discoverBtn')
		createPop(e.target.closest('.video').getAttribute('data-video-id'));
	if (e.target.className === 'close') removePop();
});

//vids 동적으로 팝업 생성 함수
function createPop(id) {
	const tags = `	
			<div class='con'>
			<iframe src='https://www.youtube.com/embed/${id}'></iframe></div>
			<span class='close'>x</span>
	`;
	const pop = document.createElement('aside');
	pop.className = 'pop';
	pop.innerHTML = tags;
	document.body.append(pop);
	console.log('.pop');

	//특정 코드를 강제로 동기화시키고 싶을때는 setTimeout에 delay를 0초로 지정해서 코드를 패키징 (강제로 wep api에 넘어갔다가 다시 콜스택 젤 마지막에 등록)
	setTimeout(() => document.querySelector('.pop').classList.add('on'), 0);
	document.body.style.overflow = 'hidden';
}

const vidsCloseBtn = document.querySelector('.close');

//팝업제거 함수
function removePop() {
	document.querySelector('.pop').classList.remove('on');
	setTimeout(() => document.querySelector('.pop').remove(), 1000);
	document.body.style.overflow = 'auto';
}

//products
const slideWrap = document.querySelector('.slideWrap');
const slideItems = Array.from(document.querySelectorAll('.slideItem'));
const numSlides = slideItems.length;
const leftArrowBtn = document.querySelector('.leftArrowBtn');
const rightArrowBtn = document.querySelector('.rightArrowBtn');

let tags = '';

fetch('DB/products.json')
	.then((res) => res.json())
	.then((data) => {
		const productsData = data.products;

		productsData.map((data) => {
			tags += `
  <div class="slideItem">
  <div class="productsImg">
  <img src="img/${data.pic}"  />
  </div>
  <div class="productsName">${data.category}</div>
  </div>`;
		});
		slideWrap.innerHTML = tags;
		duplicateSlides();
	})
	.catch((err) => {
		console.log(err);
	});

function duplicateSlides() {
	const numSlides = slideItems.length;
	for (let i = 0; i < numSlides; i++) {
		const clonedSlide = slideItems[i].cloneNode(true);
		slideWrap.appendChild(clonedSlide);
	}
}
