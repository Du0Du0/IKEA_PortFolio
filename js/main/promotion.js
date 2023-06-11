const productsSection = document.querySelector('#promotion');
const imgContainers = productsSection.querySelectorAll('.imgContainer');

imgContainers.forEach((container) => {
	const imgDescHover = container.querySelector('.imgDescHover');

	container.addEventListener('mousemove', (event) => {
		const containerRect = container.getBoundingClientRect();
		const mouseX = event.clientX - containerRect.left;
		const mouseY = event.clientY - containerRect.top;

		imgDescHover.style.left = `${mouseX}px`;
		imgDescHover.style.top = `${mouseY}px`;
	});
});
