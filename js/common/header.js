//header
const headerSection = document.querySelector('header');
const rightBar = headerSection.querySelector('.rightBar');
const leftBar = headerSection.querySelector('.leftBar');
const menuBtn = headerSection.querySelector('.menu');
const BarBtn = headerSection.querySelector('.fa-bars-staggered');
const closeBtn = headerSection.querySelector('.fa-xmark');
const circleMouse = headerSection.querySelector('.circle');

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

//header mousemove 따라다니는 원 커서 기능
document.addEventListener('mousemove', (e) => {
	const mouseX = e.clientX;
	const mouseY = e.clientY;

	circleMouse.style.left = mouseX + 'px';
	circleMouse.style.top = mouseY + 'px';
});
