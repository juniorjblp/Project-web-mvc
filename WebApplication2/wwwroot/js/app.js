const slides = document.querySelectorAll('[data-js="carousel_item"]')
const nextButton = document.querySelectorAll('[data-js="carousel_button--next"]')
const prevButton = document.querySelectorAll('[data-js="carousel_button--prev"]')

let currentSlideIndex = 0

const manipulateSlidesClasses = correctSlideIndex => {
    slides.forEach(slide => slide.classList.remove('carousel_item--visible'))
    slides[correctSlideIndex].classList.add('carousel_item--visible')
}


nextButton.addEventListener('click', () => {
    const correctSlideIndex = currectSlideIndex === slides.length - 1
        ? currentSlideIndex = 0
        : ++currentSlideIndex

    manipulateSlidesClasses(correctSlideIndex)

})

prevButton.addEventListener('click', () => {
    const correctSlideIndex = currectSlideIndex === 0
        ? currentSlideIndex = slides.length - 1
        : ++currentSlideIndex

    manipulateSlidesClasses(correctSlideIndex)
})