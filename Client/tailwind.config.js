const { orange } = require('tailwindcss/colors')
const colors = require('tailwindcss/colors')

module.exports = {
  purge: {
    content: [".Pages/**/*.razor", "./Shared/**/*.razor"],
    options: {
      keyframes: true,
    },
  },
  darkMode: false, // or 'media' or 'class'
  theme: {
    extend: {
      colors: {
        teal: colors.teal,
        cyan: colors.cyan,
        orange: orange,
      },
    },
  },
  variants: {
    extend: {},
  },
  plugins: [],
}
