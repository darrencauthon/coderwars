def weirdcase input
  input.split(' ').map do |word|
    word.downcase.chars
      .each_with_index.map { |c, i| i.even? ? c.upcase : c }
      .join('')
  end.join(' ')
end
