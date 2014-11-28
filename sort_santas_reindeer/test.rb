require_relative 'solution'
require 'minitest/autorun'
require 'minitest/spec'

describe "sorting santas reindeer" do
  it "should sort the items" do
    input = [
              "Dasher Tonoyan", 
              "Dancer Moore", 
              "Prancer Chua", 
              "Vixen Hall", 
              "Comet Karavani",        
              "Cupid Foroutan", 
              "Donder Jonker", 
              "Blitzen Claus",
            ]
    expected = [
                 "Prancer Chua", 
                 "Blitzen Claus",
                 "Cupid Foroutan", 
                 "Vixen Hall", 
                 "Donder Jonker", 
                 "Comet Karavani",        
                 "Dancer Moore", 
                 "Dasher Tonoyan", 
               ]
    sort_reindeer(input).must_equal expected
  end
end
