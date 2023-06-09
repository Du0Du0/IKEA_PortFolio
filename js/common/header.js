//header
const headerSection = document.querySelector('header');
const rightBar = headerSection.querySelector('.rightBar');
const leftBar = headerSection.querySelector('.leftBar');
const menuBtn = headerSection.querySelector('.menu');
const barBtn = headerSection.querySelector('.fa-bars-staggered');
const closeBtn = headerSection.querySelector('.fa-xmark');
const circleMouse = headerSection.querySelector('.circle');

//header menu 클릭하면 오른쪽 바 내려옴
menuBtn.addEventListener('click', (e) => {
	const isRgtOn = rightBar.classList.contains('rgt');
	const isLeftOn = leftBar.classList.contains('lft');

	toggleBarBtn();
	toggleSideBar();
	toggleButton();
});

//header mouseover 따라다니는 원 커서 기능
document.addEventListener('mousemove', (e) => {
	const mouseX = e.clientX;
	const mouseY = e.clientY;

	updatePosition(mouseX, mouseY);
});

// 사이드 바 나오는 기능
function toggleSideBar() {
	rightBar.classList.toggle('rgt');
	leftBar.classList.toggle('lft');
}

//header sideBar 열리면 버튼이 x로 바뀌고 닫히면 햄버거 버튼으로 바뀌는 기능
function toggleBarBtn() {
	const isRgtOn = rightBar.classList.contains('rgt');
	barBtn.style.display = isRgtOn ? 'block' : 'none';
	closeBtn.style.display = isRgtOn ? 'none' : 'block';
}

//header mouseover 따라다니는 원 커서 기능
function updatePosition(mouseX, mouseY) {
	circleMouse.style.left = mouseX + 'px';
	circleMouse.style.top = mouseY + 'px';
}
