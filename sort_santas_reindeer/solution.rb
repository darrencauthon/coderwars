def sort_reindeer input
  input.sort_by { |x| x.split(' ')[1] }
end
