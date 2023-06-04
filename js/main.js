//header
const headerSection = document.querySelector('header');
const rightBar = headerSection.querySelector('.rightBar');
const leftBar = headerSection.querySelector('.leftBar');
const menuBtn = headerSection.querySelector('.menu');
const BarBtn = headerSection.querySelector('.fa-bars-staggered');
const closeBtn = headerSection.querySelector('.fa-xmark');
const circleMouse = headerSection.querySelector('.circle');

//room
const roomSection = document.querySelector('#room');
const roomBtns = roomSection.querySelectorAll('.roomTab');
const roomBg = roomSection.querySelector('.roomBg');
const previewBg = roomSection.querySelector('.previewBg');
const roomTitle = roomSection.querySelector('.previewTit');
const roomSub = roomSection.querySelector('.previewSub');

//vids
const vidsSection = document.querySelector('#vids');
const videos = vidsSection.querySelectorAll('.video');
const vidsNum = vidsSection.querySelectorAll('.vidsNum');
const vidsBarTit = vidsSection.querySelectorAll('.vidsBarTit');

//header
//header menu 클릭하면 오른쪽 바 내려옴
headerSection.addEventListener('click', (e) => {
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
const roomImgs = ['preview1.png', 'preview2.png', 'preview3.png', 'preview4.png'];

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
// box클릭하면 해당 box열리는 기본 기능
videos.forEach((video, idx) => {
	video.addEventListener('click', (e) => {
		e.preventDefault();

		for (const video of videos) video.classList.remove('on');
		videos[idx].classList.add('on');

		videos[idx].classList.contains('on')
			? (vidsNum[idx].style.display = 'none')
			: (vidsBarTit[idx].style.display = 'none');

		for (let i = 0; i < videos.length; i++) {
			if (!videos[i].classList.contains('on')) {
				vidsBarTit[i].style.display = 'block';
				vidsNum[i].style.display = 'block';
			}
		}
	});
});
